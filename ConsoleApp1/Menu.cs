using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenuStudio
{
    class Menu
{
    public DateTime LastUpdated { get; set; }

    public List<MenuItem> Item { get; set; }

        public Menu(DateTime updatedTime, List<MenuItem> item)
        {
            LastUpdated = updatedTime;
            Item = item;
        }

}
}
