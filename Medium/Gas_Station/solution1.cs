public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        if(gas.Length == 1){
            if(gas[0]-cost[0] >= 0) {
                return 0;
            }else {
                return -1;
            }
        }


        int[] diff = new int[gas.Length];
        Dictionary<int,int> points = new Dictionary<int, int>();
        int gtCount = 0;
        for(int i=0; i < gas.Length; i++){
            if((gas[i] - cost[i]) > 0){
                points.Add(gtCount,i);
                gtCount++;
            }
            diff[i] = (gas[i] - cost[i]);
        }

        if(points.Count > 0){
            for(int k=0; k <points.Count; k++){
                int selectedIndex = points[k];
                int tot = 0;
                int count = 0;
                while(tot >= 0 && count < gas.Length){
                    tot  = tot + diff[(selectedIndex + count)%gas.Length];
                    count++;
                }

                if(count == gas.Length && tot >=0){
                    return selectedIndex;
                }

            }
            return -1;
            
        } 
        return -1;
    }
}