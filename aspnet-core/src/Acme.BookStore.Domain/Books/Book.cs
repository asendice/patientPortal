﻿using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Acme.BookStore.Books;

public class Book : AuditedAggregateRoot<Guid>, IMultiTenant
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }

    public Guid? TenantId { get; set; }
}
