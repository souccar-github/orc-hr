using System;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{

    public class AttendanceWithoutAdjustmentDetail : Entity
    {
        [UserInterfaceParameter(Order = 1)]
        public virtual AttendanceWithoutAdjustment AttendanceWithoutAdjustment { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual DayOfWeek DayOfWeek { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual DateTime? Date { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual bool HasVacation { get; set; } // هل اليوم فيه إجازة أو لا سواء كانت يومية او ساعية

        [UserInterfaceParameter(Order = 1)]
        public virtual bool HasMission { get; set; } // هل اليوم فيه مهمة سواء كانت يومية او ساعية أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsOffDay { get; set; } // هل اليوم هو يوم عطلة دوارة أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsHoliday { get; set; } // هل اليوم هو يوم عطلة اسبوعية أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsWorkDay { get; set; } // هل اليوم هو يوم عمل أو لا
        
        [UserInterfaceParameter(Order = 1)]
        public virtual string RequiredWorkHoursRanges { get; set; } // الوردية لليوم كمجالات لكامل الفترات
        [UserInterfaceParameter(Order = 1)]
        public virtual double RequiredWorkHoursValue { get; set; } // عدد ساعات العمل المطلوبة لهذا اليوم حسب الوردية مع طرح قيمة الاجازات اليومية او الساعية
        [UserInterfaceParameter(Order = 1)]
        public virtual string VacationRanges { get; set; } // الاجازة لليوم كمجالات لكامل الفترات
        [UserInterfaceParameter(Order = 1)]
        public virtual double VacationValue { get; set; } //  عدد ساعات الاجازة في هذا اليوم ان وجدت الساعية منها او اليومية بحيث نحول اليوم الى ساعات
        [UserInterfaceParameter(Order = 1)]
        public virtual string ActualWorkRanges { get; set; } // الدوام المحقق لليوم كمجالات لكامل الفترات
        [UserInterfaceParameter(Order = 1)]
        public virtual double ActualWorkValue { get; set; } // عدد ساعات العمل التي حققها الموظف في هذا اليوم لكامل الفترات
        [UserInterfaceParameter(Order = 1)]
        public virtual double NonAttendanceHoursValue { get; set; } // نقص دوام  لفترة ضمن الدوام
        [UserInterfaceParameter(Order = 1)]
        public virtual string NonAttendanceHoursRanges { get; set; } // نقص دوام  لفترة ضمن الدوام
        [UserInterfaceParameter(Order = 1)]
        public virtual double LatenessHoursValue { get; set; } // التأخر الصباحي
        [UserInterfaceParameter(Order = 1)]
        public virtual string LatenessHoursRanges { get; set; } // التأخر الصباحي
        [UserInterfaceParameter(Order = 1)]
        public virtual double MissionValue { get; set; } //  عدد ساعات المهمة في هذا اليوم ان وجدت الساعية منها او اليومية بحيث نحول اليوم الى ساعات
        [UserInterfaceParameter(Order = 1)]
        public virtual string MissionRanges { get; set; } //  عدد ساعات المهمة في هذا اليوم ان وجدت الساعية منها او اليومية بحيث نحول اليوم الى ساعات
        
        [UserInterfaceParameter(Order = 1)]
        public virtual double OvertimeOrderValue { get; set; } // عدد ساعات التكليف بالاضافي لهذا اليوم ان وجد
        [UserInterfaceParameter(Order = 1)]
        public virtual string OvertimeOrderRanges { get; set; } // الاضافي المكلف كمجالات لليوم كمجالات لكامل الفترات
        [UserInterfaceParameter(Order = 1)]
        public virtual double ExpectedOvertimeValue { get; set; } // الاضافي المحتمل لهذا اليوم
        [UserInterfaceParameter(Order = 1)]
        public virtual string ExpectedOvertimeRanges { get; set; } // الاضافي المحتمل لليوم كمجالات لكامل الفترات

        [UserInterfaceParameter(Order = 1)]
        public virtual double NormalOvertimeValue { get; set; } // الاضافي المحتسب -عادي- ليوم عمل عادي
        [UserInterfaceParameter(Order = 1)]
        public virtual double HolidayOvertimeValue { get; set; } // الاضافي المحتسب -عطلة- ليوم عطلة
        [UserInterfaceParameter(Order = 1)]
        public virtual double ParticularOvertimeValue { get; set; } // الاضافي المحتسب -خاصة- للفترات الخاصة
    }

}
