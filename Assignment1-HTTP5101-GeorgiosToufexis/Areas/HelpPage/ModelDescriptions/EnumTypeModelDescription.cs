using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment1_HTTP5101_GeorgiosToufexis.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}