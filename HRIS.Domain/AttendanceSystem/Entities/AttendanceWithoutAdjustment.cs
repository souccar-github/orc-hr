using System.Collections.Generic;
using System.Linq;
using HRIS.Domain.AttendanceSystem.Indexes;
using HRIS.Domain.AttendanceSystem.RootEntities;
using HRIS.Domain.EmployeeRelationServices.Enums;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{

    public class AttendanceWithoutAdjustment : Entity
    {
        public AttendanceWithoutAdjustment()
        {
            AttendanceWithoutAdjustmentDetails = new List<AttendanceWithoutAdjustmentDetail>();
        }

        [UserInterfaceParameter(Order = 1)]
        public virtual AttendanceRecord AttendanceRecord { get; set; }

        [UserInterfaceParameter(Order = 1, IsReference = true)]
        public virtual EmployeeAttendanceCard EmployeeAttendanceCard { get; set; }

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalAbsenceDaysValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Count(x => x.ActualWorkValue<=0 && !x.HasMission && !x.HasVacation && !x.IsOffDay);
            } 
        } // عدد أيام الغياب ليوم كامل

        [UserInterfaceParameter(Order = 1)]
        public virtual double InitialLatenessTotalValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Sum(x => x.LatenessHoursValue);
            }
        } // التأخر الصباحي قبل الضرب مع معامل  

        [UserInterfaceParameter(Order = 1)]
        public virtual double FinalLatenessTotalValue { get; set; } // التأخر الصباحي بعد الضرب مع معامل  

        [UserInterfaceParameter(Order = 1)]
        public virtual double InitialNonAttendanceTotalValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Sum(x => x.NonAttendanceHoursValue);
            }
        } // عدم التواجد الساعي قبل الضرب مع معامل  

        [UserInterfaceParameter(Order = 1)]
        public virtual double FinalNonAttendanceTotalValue { get; set; } // عدم التواجد الساعي بعد الضرب مع معامل  

        [UserInterfaceParameter(Order = 1)]
        public virtual PenaltyType NonAttendancePenalty { get; set; } // العقوبة المترتبة على المخالفة المتعلقة بالدوام وذلك حسب نموذج الغياب والمخالفة المرتبطة بها

        [UserInterfaceParameter(Order = 1)]
        public virtual PenaltyType LatenessPenalty { get; set; } // العقوبة المترتبة على المخالفة المتعلقة بالدوام وذلك حسب نموذج التأخر الصباحي والمخالفة المرتبطة بها

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalNormalOvertimeValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Sum(x => x.NormalOvertimeValue);
            }
        } // الاضافي الاجمالي المحتسب العادي

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalHolidayOvertimeValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Sum(x => x.HolidayOvertimeValue);
            }
        } // الاضافي الاجمالي المحتسب العطل

        [UserInterfaceParameter(Order = 1)]
        public virtual double TotalParticularOvertimeValue
        {
            get
            {
                return AttendanceWithoutAdjustmentDetails.Sum(x => x.ParticularOvertimeValue);
            }
        } // الاضافي الاجمالي المحتسب خاصة

        [UserInterfaceParameter(Order = 1)]
        public virtual double FinalTotalOvertimeValue { get; set; } // الاضافي الاجمالي المحتسب بعد الضرب بالمعامل

        [UserInterfaceParameter(Order = 1)]
        public virtual IList<AttendanceWithoutAdjustmentDetail> AttendanceWithoutAdjustmentDetails { get; set; }
        public virtual void AddAttendanceMonthlyAdjustmentDetail(AttendanceWithoutAdjustmentDetail attendanceWithoutAdjustmentDetail)
        {
            AttendanceWithoutAdjustmentDetails.Add(attendanceWithoutAdjustmentDetail);
            attendanceWithoutAdjustmentDetail.AttendanceWithoutAdjustment = this;
        }
    }

}
