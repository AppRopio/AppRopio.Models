namespace AppRopio.Models.Beacons.Responses
{
    public class BeaconModel
    {
        public string UUID { get; set; }

        public int Major { get; set; }

        public int Minor { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", UUID, Major, Minor);
        }
    }
}
