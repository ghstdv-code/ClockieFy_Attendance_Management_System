
from unittest import result
from colorama import Cursor, reinit
from numpy import True_
from tomlkit import integer, value
from database import cursor, db
from datetime import datetime, timedelta
import math


class PyDataBaseController:

    def __init__(self, hashKey, dateTime_Log, log_Type) -> None:
        self.HashKey = hashKey
        self.DateTimeLog = dateTime_Log
        self.LogType = log_Type

    id = int()
    rgHours = int(8)

    def checkExist(self):
        sql = 'SELECT em_FullName FROM tb_employee_details WHERE em_uid = %s'
        cursor.execute(
            sql, (self.HashKey,))
        result = cursor.fetchall()
        return result
    

    def SetRegularHours(self):
        self.rgHours = value

    def ReadDatabase(self):
        sql = 'SELECT id, TimeIn, TimeOut FROM tb_dtr WHERE tb_dtr.HashKey = %s AND tb_dtr.Day = %s'
        cursor.execute(
            sql, (self.HashKey, self.DateTimeLog.strftime('%y-%m-%d')))
        result = cursor.fetchall()
        return result

    def InsertAttendance(self):
        sql = '''INSERT INTO tb_dtr(HashKey, Day, TimeIn) VALUES (%s, %s, %s)'''
        cursor.execute(sql, (self.HashKey, self.DateTimeLog.strftime(
            '%y-%m-%d'), self.DateTimeLog.strftime('%H:%M:%S')))
        db.commit()

    def UpdateAttendance(self):
        sql = '''UPDATE tb_dtr SET TimeOut = %s, HoursWorked = %s WHERE id = %s'''
        cursor.execute(sql, (self.DateTimeLog.strftime(
            '%H:%M:%S'), self.ComputeTime(), self.id))
        db.commit()
        self.UpdatePerformance()

    def UpdatePerformance(self):
        sql = '''UPDATE tb_employee_details SET em_Performance = %s WHERE em_uid = %s'''
        cursor.execute(sql, (self.GetPerformace(), self.HashKey))
        print(self.GetPerformace())
        db.commit()

    def GetPerformace(self):
        sql = '''SELECT HoursWorked FROM `tb_dtr` WHERE tb_dtr.HashKey = %s ORDER BY Day LIMIT 14'''
        cursor.execute(sql, (self.HashKey, ))
        last14day = cursor.fetchall()
        hrs = 0
        for i in last14day:
            
            hrs += i[0]

        result = (hrs / (self.rgHours * 14)) * 100
     
        if result > 100:
            return 100
        else: return round(result, 2)

    def ComputeTime(self):
        dt = datetime.now()
        try:
            nowDelta = timedelta(
                hours=dt.hour, minutes=dt.minute, seconds=dt.second)
            timeDiff = nowDelta - self.ReadDatabase()[0][1]
            return round(timeDiff.total_seconds() / 3600, 2)
        except:
            return 0


    def Exist(self):
        return len(self.ReadDatabase())

    def HasOut(self):
        if str(self.ReadDatabase()[0][2]) == '0:00:00':
            self.id = self.ReadDatabase()[0][0]
            return False
        else:
            return True


#p = PyDataBaseController('d526d1cc-fc8d-457e-bec1-35f69ac53256', datetime.now(), False)
#print(p. checkExist()[0][0])
