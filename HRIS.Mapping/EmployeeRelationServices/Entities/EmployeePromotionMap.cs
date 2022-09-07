﻿#region About
//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//
//*******company name: souccar for electronic industries*******//
//author: Ammar Alziebak
//description:
//start date: 11/03/2015
//end date:
//last update:
//update by:
//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//
#endregion
#region Namespace Reference
using FluentNHibernate.Mapping;
using HRIS.Domain.EmployeeRelationServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
namespace HRIS.Mapping.EmployeeRelationServices.Entities
{
    public sealed class EmployeePromotionMap : ClassMap<EmployeePromotion>
    {
        public EmployeePromotionMap()
        {
            #region Default
            DynamicUpdate();
            DynamicInsert();
            Id(x => x.Id);
            Map(x => x.IsVertualDeleted);
            #endregion
            
            Map(x => x.PositionSeparationDate);
            Map(x => x.PositionJoiningDate);
            Map(x => x.CreationDate);
            Map(x => x.PromotionReason);
            Map(x => x.Comment);
            Map(x => x.PromotionStatus);

            References(x => x.WorkflowItem);
            References(x => x.JobTitle);
            References(x => x.Position);
            References(x => x.EmployeeCard).Column("EmployeeCard_Id");
            References(x => x.Creator);
        }
    }
}