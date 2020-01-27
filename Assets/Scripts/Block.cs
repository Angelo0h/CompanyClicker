[System.Serializable]
public class Block {
    public string id;
    public float cost;
    public int count;
    public int inicialCost;
    public string type;

    public Block(string type ,string id, float cost, int count, int inicialCost)
    {
        this.type = type;
        this.id = id;
        this.count = count;
        this.cost = cost;
        this.inicialCost = inicialCost;
    }

}