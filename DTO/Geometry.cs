namespace GeoMapping.DTO
{
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
        public event EventHandler StateChanged;


        public void Setcoordinates(List<double> coordinates)
        {
            this.coordinates = coordinates;
            StateHasChanged();
        }
        public List<double> Getcoordinates()
        {
            return this.coordinates;

        }
        private void StateHasChanged()
        {
            // This will update any subscribers
            // that the counter state has changed
            // so they can update themselves
            // and show the current counter value
            StateChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}
