using System;
using HRIS.Domain.AttendanceSystem.RootEntities;
using Souccar.Core.CustomAttribute;
using Souccar.Domain.DomainModel;

namespace HRIS.Domain.AttendanceSystem.Entities
{
    public class NormalShift : Entity // الفترات العادية للوردية
    {
        [UserInterfaceParameter(Order = 1)]
        public virtual Workshop Workshop { get; set; } //  الوردية التي سترتبط بها الفترات العادية للدوام

        [UserInterfaceParameter(Order = 1)]
        public virtual int NormalShiftOrder { get; set; } // ترتيب فترات الوردية اي الفترة الحالية مثلا هي الفترة الاولى او الثانية

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? EntryTime { get; set; } // وقت الدخول

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? ExitTime { get; set; } // وقت الخروج

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? ShiftRangeStartTime { get; set; } // الحد الادنى للدخول - وأي دخول خارج هذا المجال سيتم اهماله وكأنه غير موجود مفيد لتقييد الاضافي 

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? ShiftRangeEndTime { get; set; } // الحد الاقصى للخروج - وأي خروج خارج هذا المجال سيتم اهماله وكأنه غير موجود مفيد لتقييد الاضافي

        [UserInterfaceParameter(Order = 1)]
        public virtual bool ShiftRelatedToNextDay { get; set; } // الفترة الممتدة على يومين تكون تابعة لليوم التالي

        [UserInterfaceParameter(Order = 1)]
        public virtual int IgnoredPeriodBeforeEntryTime { get; set; } // مدة مسامحة الدخول بالدقائق - القيمة المهملة قبل وقت البدء للفترة مفيد لتقييد الاضافي

        [UserInterfaceParameter(Order = 1)]
        public virtual int IgnoredPeriodAfterEntryTime { get; set; } //  مدة مسامحة الدخول بالدقائق - القيمة المهملة بعد وقت بدء الفترة بالتالي لا تعتبر تأخر

        [UserInterfaceParameter(Order = 1)]
        public virtual int IgnoredPeriodBeforeExitTime { get; set; } // مدة المسامحة للخروج بالدقائق - القيمة المهملة قبل وقت الخروج للفترة مفيدة لعدم اعتباره خروج مبكر اي غياب غير مبرر

        [UserInterfaceParameter(Order = 1)]
        public virtual int IgnoredPeriodAfterExitTime { get; set; } // مدة المسامحة للخروج بالدقائق  - القيمة المهملة بعد وقت الخروج للفترة مفيدة لتقييد الاضافي بعد الدوام

        [UserInterfaceParameter(Order = 1)]
        public virtual int RestPeriod { get; set; } // مدة الاستراحة بالدقائق

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? RestRangeStartTime { get; set; } // وقت بدء  مجال الاستراحة بالدقائق والساعات

        [UserInterfaceParameter(Order = 1, IsTime = true)]
        public virtual DateTime? RestRangeEndTime { get; set; } // وقت انتهاء مجال الاستراحة بالدقائق والساعات
    }

    
}

