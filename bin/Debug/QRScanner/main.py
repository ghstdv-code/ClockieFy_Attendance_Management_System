from time import strftime
from unicodedata import name
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
from PyQt5.QtCore import *
from PyQt5 import uic
import cv2
from pyzbar.pyzbar import decode 
from jsonDataController import Worker as wr
from datetime import datetime, date
import numpy as np

from dbController import PyDataBaseController as pydbc

class MainUI(QMainWindow):

    def __init__(self):
        super(MainUI, self).__init__()

        uic.loadUi('Scanner.ui', self)

        self.worker = Worker()
        self.worker.start()
        self.worker.ImageUpdate.connect(self.imgSlot)
        self.worker.TextUpdate.connect(self.textSlot)
        self.cbIn.toggled.connect(lambda: self.worker.stateChanged(self.cbIn))
        self.cbOut.toggled.connect(lambda: self.worker.stateChanged(self.cbOut))
        #self.btnPowerOn.clicked.connect(self.InitiateScan)
        #self.btnStop.clicked.connect(self.cancelFeed)
        self.show()

    def textSlot(self, text):
        # set the cursor position to 0
        cursor = QTextCursor(self.txtLogs.document())
        # set the cursor position (defaults to 0 so this is redundant)
        cursor.setPosition(0)
        self.txtLogs.setTextCursor(cursor)
        self.txtLogs.insertPlainText(text)

    def imgSlot(self, img):
        self.outBox.setPixmap(QPixmap.fromImage(img))

    def cancelFeed(self):
        self.worker.stop()
        self.outBox.clear()
        self.outBox.update()      

class Worker(QThread):
    TextUpdate = pyqtSignal(str)
    ImageUpdate = pyqtSignal(QImage)



    def run(self):
        cap = cv2.VideoCapture(0)
        self.threadActive = True
        while self.threadActive:
            ret, frame = cap.read()
            if ret:
                for qr in decode(frame):
                    decodedText = qr.data.decode('utf-8')
                    pts = np.array([qr.polygon], np.int32)
                    pts.reshape(-1, 1, 2)
                    cv2.polylines(frame, [pts], True, (0, 225, 0), 5)
                    pts2 = qr.rect    
                    cv2.putText(frame, decodedText, (pts2[0], pts2[1]-10), cv2.FONT_HERSHEY_SIMPLEX, 0.7, (0, 225, 0), 2)

                    #wm = wr(decodedText)
                    
                    pdb = pydbc(decodedText, datetime.now(), True if self.logType == 'In' else False)
                    
                    appLogs = ''
                    if len(pdb.checkExist()) > 0:
                        
                        if(pdb.Exist()):
                            if self.logType == 'In':
                                appLogs = 'Employee is was already In\n'
                            else:
                                try:
                                    if not pdb.HasOut():
                                        pdb.UpdateAttendance()
                                        appLogs = '<Time Out> {name} <{timeNow}>\n'.format(name = pdb.checkExist()[0][0], timeNow=datetime.now().strftime('%H:%M:%S'))
                                    else:
                                        appLogs = 'Employee is was already Out\n'
                                except: pass
                        else:  
                            pdb.InsertAttendance()
                            appLogs = '<Time In> {name} <{timeNow}>\n'.format(name = pdb.checkExist()[0][0], timeNow=datetime.now().strftime('%H:%M:%S'))
                
                    else:
                        appLogs = 'UnAuthorized Qr Code Detected\n'
                    
                    self.TextUpdate.emit(appLogs)       

                Image = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
                FlippedImage = cv2.flip(Image, 1)
                ConvertToQtFormat = QImage(FlippedImage.data, FlippedImage.shape[1], FlippedImage.shape[0], QImage.Format_RGB888)
                Pic = ConvertToQtFormat.scaled(310, 290)
                self.ImageUpdate.emit(Pic) 

    def stop(self):
        self.threadActive = False
        self.quit()

    def updateLabel(self):
        self.TextUpdate.emit('Ready') 

    logType = 'In'

    def stateChanged(self, b):
        if(b.text() == 'In'):
            self.logType = 'In'
        else:
            self.logType = 'Out'

def mainLauncher():
    import sys
    app = QApplication(sys.argv)
    window = MainUI()
    app.exec_();

if __name__ == '__main__':
    mainLauncher()
