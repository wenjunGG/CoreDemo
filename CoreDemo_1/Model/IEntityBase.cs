using Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IEntityBase
    {
        int Id { get; set; }
        RecordStatus RecordStatus { get; set; }
    }
}
