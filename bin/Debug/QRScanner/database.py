import mysql.connector

config = {
    'user': 'root',
    'passwd': "",
    'host': 'localhost',
    'database': 'db_attendance'
}

db = mysql.connector.connect(**config)
cursor  = db.cursor()