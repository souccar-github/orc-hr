using System;
using HRIS.Domain.AttendanceSystem.Enums;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{

    public class AttendanceDailyAdjustmentDetail : Entity
    {
        [UserInterfaceParameter(Order = 1)]
        public virtual AttendanceDailyAdjustment AttendanceDailyAdjustment { get; set; }

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
        public virtual double VacationValue { get; set; } //  عدد ساعات الاجازة في هذا اليوم ان وجدت الساعية منها او اليومية بحيث نحول اليوم الى ساعات

        [UserInterfaceParameter(Order = 1)]
        public virtual double WorkHoursValue { get; set; } // عدد ساعات العمل حسب الوردية بهذا اليوم لكامل الفترات

        [UserInterfaceParameter(Order = 1)]
        public virtual double MissionValue { get; set; }  // عدد ساعات المهمة لليوم سواء كانت يومية او ساعية

        [UserInterfaceParameter(Order = 1)]
        public virtual double RequiredWorkHoursValue
        {
            get
            {
                return WorkHoursValue - VacationValue - MissionValue;
            }
        } // عدد ساعات العمل المطلوبة لهذا اليوم حسب الوردية مع طرح قيمة الاجازات اليومية او الساعية  وكذلك المهام اليومية والساعية

        [UserInterfaceParameter(Order = 1)]
        public virtual double ActualWorkHoursValue { get; set; } // عدد ساعات العمل التي حققها الموظف في هذا اليوم لكامل الفترات

        [UserInterfaceParameter(Order = 1)]
        public virtual DailyAdjustmentAttendanceStatus DailyAdjustmentAttendanceStatus
        {
            get
            {
                if (ActualWorkHoursValue == 0 && IsWorkDay && !HasMission && !HasVacation)
                {
                    return DailyAdjustmentAttendanceStatus.Absence;
                }
                if (ActualWorkHoursValue == RequiredWorkHoursValue)
                {
                    return DailyAdjustmentAttendanceStatus.Ok;
                }
                if (ActualWorkHoursValue < RequiredWorkHoursValue && ActualWorkHoursValue > 0)
                {
                    return DailyAdjustmentAttendanceStatus.NonAttendance;
                }
                if (ActualWorkHoursValue > RequiredWorkHoursValue)
                {
                    return DailyAdjustmentAttendanceStatus.Overtime;
                }
                return DailyAdjustmentAttendanceStatus.Ok;
            }
        }

        [UserInterfaceParameter(Order = 1)]
        public virtual double NonAttendanceHoursValue
        {
            get
            {
                return (RequiredWorkHoursValue - ActualWorkHoursValue) > 0 ? RequiredWorkHoursValue - ActualWorkHoursValue : 0;
            }
        } // نقص الدوام اليومي سواء بسبب عدم التواجد ضمن اليوم او بسبب التأخر الصباحي

        [UserInterfaceParameter(Order = 1)]
        public virtual double OvertimeOrderValue { get; set; } // عدد ساعات التكليف بالاضافي لهذا اليوم ان وجد

        [UserInterfaceParameter(Order = 1)]
        public virtual double ExpectedOvertimeValue
        {
            get
            {
                return ActualWorkHoursValue > RequiredWorkHoursValue
                    ? ActualWorkHoursValue - RequiredWorkHoursValue
                    : 0;
            }
        } // الاضافي المحتمل لهذا اليوم

        [UserInterfaceParameter(Order = 1)]
        public virtual double OrderedOvertimeValue
        {
            get
            {
                return ExpectedOvertimeValue > OvertimeOrderValue
                    ? OvertimeOrderValue
                    : ExpectedOvertimeValue;
            }
        } // الاضافي المكلف القيمة الصغرى بين المحتمل وعدد ساعات التكليف

        [UserInterfaceParameter(Order = 1)]
        public virtual double NormalOvertimeValue { get; set; } // الاضافي المحتسب -عطلة- ليوم عادي

        [UserInterfaceParameter(Order = 1)]
        public virtual double HolidayOvertimeValue { get; set; } // الاضافي المحتسب -عادي- ليوم عمل عطلة 

    }

}
