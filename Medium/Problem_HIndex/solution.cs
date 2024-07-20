public class Solution {
    public int HIndex(int[] citations) {

        int checkValue = citations.Length;
        int result = 0;
        
        while(checkValue > 0) {
            result = 0;
            for(int i= 0; i < citations.Length; i++) {
        
                if(citations[i] >= checkValue){
                    result++;
                }
            }

            Console.WriteLine(result.ToString());
            Console.WriteLine(checkValue.ToString());
            if(checkValue <= result){
                return checkValue;
            }
            checkValue--;
        }

        return 0;

    }
}