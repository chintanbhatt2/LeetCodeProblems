class Airport:
    def __init__(self, name: str):
        self.code = name
        self.outbound =[]
    def addOutbound(self, string):
        self.outbound.append(string)
    def takeFlight(self):
        return self.outbound.pop(0)

class Solution:
    def findItinerary(self, tickets: list ) -> list:
        airports = []
        names = []
        for flights in tickets:
            if not flights[0] in names:
                names.append(flights[0])
                airports.append(Airport(flights[0]))
            if not flights[1] in names:
                names.append(flights[1])
                airports.append(Airport(flights[1]))                
        for flights in tickets:
            finder = flights[0]
            for i, x in enumerate(airports):
                if finder == x.code:
                    airports[i].addOutbound(flights[1])
        for x in range(len(airports)):
            airports[x].outbound.sort()
        startIndex = 0
        for i, x in enumerate(airports):
            if x.code == "JFK":
                startIndex = i
                break
        iten = ["JFK"]
        while(len(airports) != 0):
            if len(airports[startIndex].outbound) == 0:
                if len() == 0:
                    break
            currentFlight = airports[startIndex].takeFlight()
            iten.append(currentFlight)
            if len(airports[startIndex].outbound) == 0:
                airports.pop(i)
            for i, x in enumerate(airports):
                if x.code == currentFlight:
                    startIndex = i 
                    break        

        return iten

            




def main():
    input1 = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
    input2 = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
    input3 = [["JFK","KUL"],["JFK","NRT"],["NRT","JFK"]]
    sol = Solution()
    sol.findItinerary(input1)

if __name__ == "__main__":
    main()