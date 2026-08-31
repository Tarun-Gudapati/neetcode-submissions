public class MinStack {


    List<int> ls=new();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        ls.Add(val);
    }
    
    public void Pop() {
        ls.RemoveAt(ls.Count-1);
    }
    
    public int Top() {
        return ls[ls.Count-1];
    }
    
    public int GetMin() {
        int min=int.MaxValue;
        foreach(int i in ls)
        {
            min=Math.Min(i,min);
        }
        return min;
    }
}
