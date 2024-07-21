public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalC=0,index=0;
        int fuel=0;
        for(int i=0;i<gas.Length;i++){
            totalC+=gas[i]-cost[i];
            fuel+=gas[i]-cost[i];
            if(fuel<0){
                fuel=0;
                index=i+1;
            }
        }
        return totalC>=0?index:-1;
    }
}