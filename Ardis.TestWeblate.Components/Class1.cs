using Ardis.TestWeblate.Components.Properties;
using System.ComponentModel.DataAnnotations;

namespace Ardis.TestWeblate.Components
{
    public class Person
    {
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Person_name_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Person_name_Description))]
        public string name { get; set; }
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Person_age_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Person_age_Description))]
        public string age { get; set; }
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Person_adress_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Person_adress_Description))]
        public string adress { get; set; }
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Person_city_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Person_city_Description))]
        public string city { get; set; }

    }


    public class Car
    {
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Car_brand_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Car_brand_Description))]
        public string brand { get; set; }
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Car_color_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Car_color_Description))]
        public string color { get; set; }
        [Display(Name = nameof(Resources.Ardis_TestWeblate_Components_Car_numberOfDoors_Name), ResourceType = typeof(Resources), Description = nameof(Resources.Ardis_TestWeblate_Components_Car_numberOfDoors_Description))]
        public int numberOfDoors { get; set; }
    }
}