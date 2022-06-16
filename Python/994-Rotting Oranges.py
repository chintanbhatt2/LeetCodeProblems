#994. Rotting Oranges

import copy

def orangesRotting(grid) -> int:
    allRotten = False;
    prevGrid = copy.deepcopy(grid);
    currGrid = copy.deepcopy(grid);
    minutes = 0;
    while(allRotten == False):
        prevGrid = copy.deepcopy(currGrid)
        for i, row in enumerate(prevGrid):
            for j, col in enumerate(row):
                if(prevGrid[i][j] == 2):
                    if(prevGrid[max(i-1, 0)][j] == 1):
                        currGrid[max(i-1, 0)][j] = 2
                    if(prevGrid[i][max(j-1, 0)] == 1):
                        currGrid[i][max(j-1, 0)] = 2
                    if(prevGrid[min(i+1, len(grid)-1)][j] == 1):
                        currGrid[min(i+1, len(grid)-1)][j] = 2
                    if(prevGrid[i][min(j+1, len(row)-1)] == 1):
                        currGrid[i][min(j+1, len(row)-1)] = 2
        if(currGrid == prevGrid):
            allRotten = True
        else:
            minutes = minutes + 1
    finalBool = True 
    for x in currGrid:
        for y in x:
            if y == 1:
                finalBool = False 

    if (finalBool):
        return minutes
    else:
        return -1
        



print(orangesRotting([[1,2]]))