using System.Collections.Generic;
using System.Linq;
using HRIS.Domain.AttendanceSystem.Enums;
using HRIS.Domain.AttendanceSystem.Indexes;
using HRIS.Domain.AttendanceSystem.RootEntities;
using HRIS.Domain.EmployeeRelationServices.Enums;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{
    public class AttendanceDailyAdjustment : Entity
    {
        public AttendanceDailyAdjustment()
        {
            AttendanceDailyAdjustmentDetails = new List<AttendanceDailyAdjustmentDetail>();
        }

        [UserInterfaceParameter(Order = 1)]
        public virtual AttendanceRecord AttendanceRecord { get; set; }

        [UserInterfaceParameter(Order = 1,IsReference = true)]
        public virtual EmployeeAttendanceCard EmployeeAttendanceCard { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalAbsenceDays
        {
            get
            {
                return AttendanceDailyAdjustmentDetails == null 
                    ? 0 
                    : AttendanceDailyAdjustmentDetails.Count(x => x.DailyAdjustmentAttendanceStatus == DailyAdjustmentAttendanceStatus.Absence);
            }
        } // عدد الايام التي حالة السجل فيها غياب

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalNormalOvertimeValue {
            get
            {
                return AttendanceDailyAdjustmentDetails == null
                    ? 0
                    : AttendanceDailyAdjustmentDetails.Sum(x => x.NormalOvertimeValue);
            }
        } // الاضافي الاجمالي المحتسب العادي

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalHolidayOvertimeValue
        {
            get
            {
                return AttendanceDailyAdjustmentDetails == null
                    ? 0
                    : AttendanceDailyAdjustmentDetails.Sum(x => x.HolidayOvertimeValue);
            }
            
        } // الاضافي الاجمالي المحتسب العطل

        [UserInterfaceParameter(Order = 1)]
        public virtual double FinalOvertimeValue { get; set; } // الاضافي المحتسب بعد معامل الضرب

        [UserInterfaceParameter(Order = 1)]
        public virtual double InitialNonAttendanceValue
        {
            get
            {
                return AttendanceDailyAdjustmentDetails == null
                    ? 0
                    : AttendanceDailyAdjustmentDetails.Sum(x => x.NonAttendanceHoursValue);
            }
        } //  عدم التواجد الشهري قبل معامل الضرب

        [UserInterfaceParameter(Order = 1)]
        public virtual double FinalNonAttendanceValue { get; set; } //  عدم التواجد الشهري بعد معامل الضرب

        [UserInterfaceParameter(Order = 1)]
        public virtual PenaltyType Penalty { get; set; } // العقوبة المترتبة على المخالفة المتعلقة بالدوام وذلك حسب نموذج التأخير والمخالفة المرتبطة بها

        [UserInterfaceParameter(Order = 1)]
        public virtual IList<AttendanceDailyAdjustmentDetail> AttendanceDailyAdjustmentDetails { get; set; }
        public virtual void AddAttendanceDailyAdjustmentDetail(AttendanceDailyAdjustmentDetail attendanceDailyAdjustmentDetail)
        {
            AttendanceDailyAdjustmentDetails.Add(attendanceDailyAdjustmentDetail);
            attendanceDailyAdjustmentDetail.AttendanceDailyAdjustment = this;
        }
    }
}
