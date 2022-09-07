using System;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{

    public class AttendanceMonthlyAdjustmentDetail : Entity
    {
        [UserInterfaceParameter(Order = 1)]
        public virtual AttendanceMonthlyAdjustment AttendanceMonthlyAdjustment { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual DayOfWeek DayOfWeek { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual DateTime? Date { get; set; }

        //[UserInterfaceParameter(Order = 1)]
        //public virtual AttendanceType AttendanceType { get; set; } // هل هو يوم عمل للموظف او كان في اجازة او عطلة او مهمة او عطلة دوارة

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsWorkDay { get; set; } // هل اليوم هو يوم عمل أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool HasVacation { get; set; } // هل اليوم فيه إجازة يومية وساعية أو لا   

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsOffDay { get; set; } // هل اليوم هو يوم عطلة دوارة أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool IsHoliday { get; set; } // هل اليوم هو يوم عطلة اسبوعية أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual bool HasMission { get; set; } // هل اليوم فيه مهمة سواء كانت يومية او ساعية أو لا

        [UserInterfaceParameter(Order = 1)]
        public virtual double VacationValue { get; set; } //  عدد ساعات الاجازة في هذا اليوم ان وجدت الساعية منها او اليومية بحيث نحول اليوم الى ساعات

        [UserInterfaceParameter(Order = 1)]
        public virtual double OvertimeOrderValue { get; set; } // عدد ساعات التكليف بالاضافي لهذا اليوم ان وجد

        [UserInterfaceParameter(Order = 1)]
        public virtual double WorkHoursValue { get; set; } // عدد ساعات العمل حسب الوردية بهذا اليوم لكامل الفترات

        [UserInterfaceParameter(Order = 1)]
        public virtual double ActualWorkHoursValue { get; set; } // عدد ساعات العمل التي حققها الموظف في هذا اليوم لكامل الفترات

        [UserInterfaceParameter(Order = 1)]
        public virtual double MissionValue { get; set; } // عدد ساعات المهمة لليوم سواء كانت يومية او ساعية

        [UserInterfaceParameter(Order = 1)]
        public virtual double RequiredWorkHoursValue
        {
            get
            {
                return WorkHoursValue - VacationValue - MissionValue;
            }
        } // عدد ساعات العمل المطلوبة لهذا اليوم حسب الوردية مع طرح قيمة الاجازات اليومية او الساعية  وكذلك المهام اليومية والساعية
    }

}
