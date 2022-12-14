import pandas as pd

class Animals:
    
    dframe = dict()

    def __init__(self, name="", legs=0):
        self.name = name
        self.legs = legs
    
    def showDetails(self):
        print(("{name} has {legs} legs.").format(name=self.name, legs=self.legs))
        
    def createDataFrame(self):
        data = {'name':self.name, 'LegCount':self.legs}
        df = pd.DataFrame(list(data.items()))
        df.to_pickle('./datatest1.itlog')
        
    def readfromDataFrame(self):
        self.dframe = pd.read_pickle('./datatest1.itlog')
        
    def loadData(self):
        self.readfromDataFrame()
        return self.dictionary
    
    def testFunc(self):
        #toUpdateDic = dict({'name':self.name, 'LegCount':self.legs})
        #oldData = self.dictionary
        
        print(self.dframe)
        
        
an =  Animals('NAtoy', 4)
an.testFunc()