namespace GameZork.DataAccessLayer.Models
{
    public class Weapon : BaseDataObject
    {
        public string Name { get; set; }
        public int MissRate { get; set; }
        public int Damage { get; set; }
    }
}
