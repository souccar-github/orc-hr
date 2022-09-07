using System;
using HRIS.Domain.AttendanceSystem.RootEntities;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{
    public class ParticularOvertimeShift : Entity // الفترات الخاصة للوردية
    {
        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? StartTime { get; set; } // توقيت البداية ويكون ساعات ودقائق

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? EndTime { get; set; } // توقيت النهاية ويكون ساعات ودقائق

        [UserInterfaceParameter(Order = 1)]
        public virtual  Workshop Workshop { get; set; } // الوردية الاب لهذه الفترة الخاصة
    }
}
