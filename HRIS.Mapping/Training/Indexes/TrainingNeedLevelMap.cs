﻿using FluentNHibernate.Mapping;
using HRIS.Domain.Training.Indexes;
using Souccar.Core;

namespace HRIS.Mapping.Training.Indexes
{
    public sealed class TrainingNeedLevelMap : ClassMap<TrainingNeedLevel>
    {
        public TrainingNeedLevelMap()
        {
            Id(x => x.Id);
            Map(x => x.IsVertualDeleted);
            Map(x => x.Name).Length(GlobalConstant.SimpleStringMaxLength).Unique();
            Map(x => x.Order).Column("ValueOrder");
        }
    }
}