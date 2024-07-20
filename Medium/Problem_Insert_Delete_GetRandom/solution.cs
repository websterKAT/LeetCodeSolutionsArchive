vusing System;
using System.Collections.Generic;

public class RandomizedSet {
    private Dictionary<int, int> valueToIndex;
    private List<int> values;
    private Random random;

    public RandomizedSet() {
        valueToIndex = new Dictionary<int, int>();
        values = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (valueToIndex.ContainsKey(val)) {
            return false;
        }
        valueToIndex[val] = values.Count;
        values.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!valueToIndex.ContainsKey(val)) {
            return false;
        }
        
        // Move the last element to the place of the one to remove
        int indexToRemove = valueToIndex[val];
        int lastValue = values[values.Count - 1];
        values[indexToRemove] = lastValue;
        valueToIndex[lastValue] = indexToRemove;
        
        // Remove the last element
        values.RemoveAt(values.Count - 1);
        valueToIndex.Remove(val);
        
        return true;
    }
    
    public int GetRandom() {
        int index = random.Next(values.Count);
        return values[index];
    }
}