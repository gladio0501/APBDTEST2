namespace Test2.DTOs
{
    public class AddItemDTO
    {
        public int ItemId { get; set; }
        public String name { get; set; }
        public int Amount { get; set; }
    }

    public class AddedItemDTO
    {
        public int CharacterId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
    }
}