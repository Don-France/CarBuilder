namespace CarBuilder.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public int WheelId { get; set; }
    public int TechnologyId { get; set; }
    public int PaintColorId { get; set; }
    public int InteriorId { get; set; }
    public PaintColor PaintColor { get; set; }
    public Interior Interior { get; set; }
    public Technology Technology { get; set; }
    public Wheels Wheels { get; set; }


}