from QRScanner.jsonDataController import Worker as jdc

uid = str()
name = str()

class Bridge:
        
    def CreateObject():
        sr  = jdc(uid, name)
        sr.addOne()

    def DeleteObject():
        sr = jdc()
        sr.deleteItem(uid)

    def test():
        print('this is test')