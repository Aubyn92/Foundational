using System;
using System.Collections.Generic;

namespace AllergyTest
{
    public class PersonAllergyScore
    {
        public int AllergyTest()
            {
                List<string> allergyList = new List<string>();
                foreach (Allergens name in Enum.GetValues(typeof(Allergens)))
                {
                    if ((Allergens name & ) != 0)
                    {
                        AllergyList.Add(allergen.ToString());
                    }
                }
            }

            public bool IsAllergic(List<string> allergy)
            {
                // if statement returning true/ false for whether allergyList contains allergy item
                if (allergies.Contains(allergy))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public List<string> List()
            {
                return allergies;
            }
    }
}