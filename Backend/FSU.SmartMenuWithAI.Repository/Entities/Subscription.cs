﻿using System;
using System.Collections.Generic;

namespace FSU.SmartMenuWithAI.Repository.Entities;

public partial class Subscription
{
    public int SubscriptionId { get; set; }

    public string SubscriptionCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Status { get; set; }

    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public int PaymentId { get; set; }

    public int PlanId { get; set; }

    public virtual Payment Payment { get; set; } = null!;

    public virtual Plan Plan { get; set; } = null!;
}
