using System;
using System.Text;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList){
        var newList = new List<bool>();
        for(int i = 0; i < myList.Count; i++){
            if (myList[i] % 2 == 0){
                newList.Add(true);
            }
            else{
                newList.Add(false);
            }
        }
        return newList;
    }
}
