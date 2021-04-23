class Flight:
    def __init__(self, tickets: list):
        self.start = tickets[0]
        self.end = tickets[1]
        self.redeemed = False

class Solution:
    def findItinerary(self, tickets: list ) -> list:
        flights = []
        for x in tickets:
            flights.append(Flight(x))
        print(flights)
        minFlight = Flight(["NULL", "NULL"])
        minFlightNum = 0
        for i, flight in enumerate(flights):
            if (flight.start == "JFK"):
                if (flight.end < minFlight.end or minFlight.end == "NULL"):
                    minFlight = flight 
                    minFlightNum = i 
        endCheck = False
        while(not endCheck):
            startFlight = flights[i]
            




def main():
    input1 = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
    input2 = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
    sol = Solution()
    sol.findItinerary(input2)

if __name__ == "__main__":
    main()