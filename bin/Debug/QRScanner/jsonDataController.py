import json

path = 'data.json'

class Worker:
    def __init__(self, idNumber = 0, name = None) -> None:
        self.idNumber  = idNumber
        self.name = name

    
    def printInfo(self):
        print(('Name: {name}\nId: {id}').format(name =self.name, id = self.idNumber))

    def writer(self, dictionary):
        fs = open(path, 'w')
        json.dump(dictionary, fs, indent=2)
        fs.close()

    def reader(self):
        fs = open(path,'r')
        self.dictionary = json.load(fs)
        fs.close()

    def createDictionary(self):
        emp_dict = {self.idNumber:self.name}
        self.writer(emp_dict)

    def addOne(self):
        data = self.loadDictionary()
        if not str(self.idNumber) in data:
            dic = {self.idNumber:self.name}
            data.update(dic)
            self.writer(data)
        else:
            #TODO add logic
            pass

    def loadDictionary(self):
        self.reader()
        return self.dictionary
        
    def deleteItem(self, id):
        data = self.loadDictionary()
        del data[str(id)]
        self.writer(data)

    def fetchItem(self):
        self.reader()
        return self.dictionary[str(self.idNumber)]

    def IsExist(self):
        data = self.loadDictionary()
        if str(self.idNumber) in data:
            return True
        return False