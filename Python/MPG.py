"""
Daniel Bruce
5/4/2018
Assignment #11
MPG.py
Calculates MPG using a GUI inteface
"""
import tkinter

class Mpg:
    def __init__(self):
  
        self.theWindow = tkinter.Tk()
        #self.calcvar = calc
        #7 frames per second
        self.titleFrame = tkinter.Frame(self.theWindow)
        self.galFrame = tkinter.Frame(self.theWindow)
        self.mileFrame = tkinter.Frame(self.theWindow)
        self.calcFrame = tkinter.Frame(self.theWindow)
        self.buttonFrame = tkinter.Frame(self.theWindow)
        
        #labels
        self.titleLabel = tkinter.Label(self.titleFrame, text='Calculate Your MPG')
        self.space1Label = tkinter.Label(self.titleFrame, text='')
        self.galLabel = tkinter.Label(self.galFrame, text='Gallons Per Tank:  ')
        self.mileLabel = tkinter.Label(self.mileFrame, text='Miles Per Tank:     ')
        self.space2Label = tkinter.Label(self.calcFrame, text='')
        self.space3Label = tkinter.Label(self.buttonFrame, text='')
        self.mpgLabel = tkinter.Label(self.calcFrame, text='MPG:        ')
        self.resultsLabel = tkinter.Label(self.calcFrame, textvariable = '')

        #text boxes
        self.galTextbox = tkinter.Entry(self.galFrame, width=5)
        self.mileTextbox = tkinter.Entry(self.mileFrame, width=5)

        #buttons
        self.exitButton = tkinter.Button(self.buttonFrame, text='Exit',\
                                         command = self.theWindow.destroy,\
                                         activebackground = 'red')
        self.calcButton = tkinter.Button(self.buttonFrame, text='Calculate MPG',\
                                         command = self.calcMPG,\
                                         activebackground = 'lavender')
                                        #they have chartreuse!
        
        
        #Greenbay Packers
        self.titleLabel.pack(side = 'top')
        self.space1Label.pack(side = 'bottom')
        self.galLabel.pack(side = 'left')
        self.mileLabel.pack(side = 'left')
        self.space2Label.pack(side = 'top')
        self.mpgLabel.pack(side = 'left')
        self.resultsLabel.pack(side='right')
        self.space3Label.pack(side = 'top')

        self.galTextbox.pack(side = 'right')
        self.mileTextbox.pack(side = 'right')

        self.exitButton.pack(side = 'left')
        self.calcButton.pack(side = 'right')

        self.titleFrame.pack(side = 'top')
        self.galFrame.pack(side = 'top')
        self.mileFrame.pack(side = 'top')
        self.calcFrame.pack(side = 'top')
        self.buttonFrame.pack(side = 'top')
        #last line
        tkinter.mainloop()
    #end __init__
    def calcMPG(self):
        gal = float(self.galTextbox.get())
        mile = float(self.mileTextbox.get())

        mpg = mile/gal
        #print(mpg)
        self.resultsLabel.config(text = format(mpg,'.1f'))
        
    #end calcMPG
       

        
    
#end Mpg
my_gui = Mpg()

#rip in peace main() you will be missed
