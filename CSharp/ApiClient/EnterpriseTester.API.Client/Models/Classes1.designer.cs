using System.Collections.Generic;
using System.Linq;

namespace EnterpriseTester.API.Client.Models
{
    public partial class AbstractWidget : EtRestEntityBase 
    {
        public string Description { get; set; }
        public string FieldCategory { get; set; }
        public string FormName { get; set; }
        public string HandlerType { get; set; }
        public bool? Hidden { get; set; }
        public string ImplementationType { get; set; }
        public string ItemId { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public bool? ReadOnly { get; set; }
        public bool? Required { get; set; }
        public int? TabIndex { get; set; }
        public string ValueType { get; set; }
        public string WidgetType { get; set; }
        
        public AbstractWidget Clone(bool includeLocalProperties)
        {
            var c = new AbstractWidget
                    {
                        Description = Description,
                        FieldCategory = FieldCategory,
                        FormName = FormName,
                        HandlerType = HandlerType,
                        Hidden = Hidden,
                        ImplementationType = ImplementationType,
                        ItemId = ItemId,
                        Label = Label,
                        Name = Name,
                        ReadOnly = ReadOnly,
                        Required = Required,
                        TabIndex = TabIndex,
                        ValueType = ValueType,
                        WidgetType = WidgetType,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AbstractWidget clone, bool includeLocalProperties);
    }


    public partial class Add : EtRestEntityBase 
    {
        public string ownerId { get; set; }
        public int sortOrder { get; set; }
        public string text { get; set; }
        
        public Add Clone(bool includeLocalProperties)
        {
            var c = new Add
                    {
                        ownerId = ownerId,
                        sortOrder = sortOrder,
                        text = text,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Add clone, bool includeLocalProperties);
    }


    public partial class AgileRun : EtRestEntityBase, IHasId 
    {
        public AgileRun()
        {
            Steps = new List<AgileRunStep>();
            Widgets = new List<AbstractWidget>();
        }

        public string ActualDuration { get; set; }
        public bool AgileRunNumberReadOnly { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public string Description { get; set; }
        public string EstimatedDuration { get; set; }
        public string ExecutionStatus { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int? Number { get; set; }
        public string Objective { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string PostCondition { get; set; }
        public string PreCondition { get; set; }
        public Picklist Priority { get; set; }
        public string PriorityId { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string SourceContainerId { get; set; }
        public string SourceId { get; set; }
        public Picklist Status { get; set; }
        public string StatusId { get; set; }
        public List<AgileRunStep> Steps { get; set; }
        public Picklist Type { get; set; }
        public string TypeId { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public AgileRun Clone(bool includeLocalProperties)
        {
            var c = new AgileRun
                    {
                        ActualDuration = ActualDuration,
                        AgileRunNumberReadOnly = AgileRunNumberReadOnly,
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        Description = Description,
                        EstimatedDuration = EstimatedDuration,
                        ExecutionStatus = ExecutionStatus,
                        FieldValues = FieldValues,
                        Id = Id,
                        Name = Name,
                        Notes = Notes,
                        Number = Number,
                        Objective = Objective,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        PackageName = PackageName,
                        PostCondition = PostCondition,
                        PreCondition = PreCondition,
                        Priority = Priority,
                        PriorityId = PriorityId,
                        Project = Project,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        SourceContainerId = SourceContainerId,
                        SourceId = SourceId,
                        Status = Status,
                        StatusId = StatusId,
                        Type = Type,
                        TypeId = TypeId,
                        Steps = Steps.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AgileRun clone, bool includeLocalProperties);
    }


    public partial class AgileRunStep : EtRestEntityBase, IHasId 
    {
        public string ActualResult { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public string ExpectedResult { get; set; }
        public bool? HasAttachments { get; set; }
        public bool? HasIncidents { get; set; }
        public string Id { get; set; }
        public string Notes { get; set; }
        public int OrderNumber { get; set; }
        public string Result { get; set; }
        
        public AgileRunStep Clone(bool includeLocalProperties)
        {
            var c = new AgileRunStep
                    {
                        ActualResult = ActualResult,
                        Data = Data,
                        Description = Description,
                        ExpectedResult = ExpectedResult,
                        HasAttachments = HasAttachments,
                        HasIncidents = HasIncidents,
                        Id = Id,
                        Notes = Notes,
                        OrderNumber = OrderNumber,
                        Result = Result,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AgileRunStep clone, bool includeLocalProperties);
    }


    public partial class AgileRunStepAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string RunId { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        public string StepId { get; set; }
        
        public AgileRunStepAttachment Clone(bool includeLocalProperties)
        {
            var c = new AgileRunStepAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        RunId = RunId,
                        Size = Size,
                        SourceId = SourceId,
                        StepId = StepId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AgileRunStepAttachment clone, bool includeLocalProperties);
    }


    public partial class AgileRunStepIncident : EtRestEntityBase 
    {
        public string IncidentId { get; set; }
        public string RunId { get; set; }
        public string StepId { get; set; }
        
        public AgileRunStepIncident Clone(bool includeLocalProperties)
        {
            var c = new AgileRunStepIncident
                    {
                        IncidentId = IncidentId,
                        RunId = RunId,
                        StepId = StepId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AgileRunStepIncident clone, bool includeLocalProperties);
    }


    public partial class AssignedTo : EtRestEntityBase, IHasId 
    {
        public string CssClass { get; set; }
        public string GlobalId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
        public AssignedTo Clone(bool includeLocalProperties)
        {
            var c = new AssignedTo
                    {
                        CssClass = CssClass,
                        GlobalId = GlobalId,
                        Id = Id,
                        Name = Name,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AssignedTo clone, bool includeLocalProperties);
    }


    public partial class AutomatedTest : EtRestEntityBase, IHasId 
    {
        public AutomatedTest()
        {
            Assignments = new List<AutomatedTestAssignment>();
        }

        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public List<AutomatedTestAssignment> Assignments { get; set; }
        public object Configuration { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedById { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Type { get; set; }
        
        public AutomatedTest Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTest
                    {
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        Configuration = Configuration,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        CreatedById = CreatedById,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedBy = LastUpdatedBy,
                        LastUpdatedById = LastUpdatedById,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        PackageName = PackageName,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        Type = Type,
                        Assignments = Assignments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTest clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestAssignment : EtRestEntityBase, IHasId 
    {
        public AutomatedTestAssignment()
        {
            Runs = new List<AutomatedTestRun>();
        }

        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public AutomatedTest AutomatedTest { get; set; }
        public string AutomatedTestId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public ExecutionPackage Package { get; set; }
        public string PackageId { get; set; }
        public List<AutomatedTestRun> Runs { get; set; }
        public string Status { get; set; }
        public ITotals Totals { get; set; }
        
        public AutomatedTestAssignment Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestAssignment
                    {
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        AutomatedTest = AutomatedTest,
                        AutomatedTestId = AutomatedTestId,
                        Id = Id,
                        Name = Name,
                        Package = Package,
                        PackageId = PackageId,
                        Status = Status,
                        Totals = Totals,
                        Runs = Runs.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestAssignment clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestRun : EtRestEntityBase, IHasId 
    {
        public AutomatedTestAssignment Assignment { get; set; }
        public string AssignmentId { get; set; }
        public string FinishedAt { get; set; }
        public string Id { get; set; }
        public string ImportedAt { get; set; }
        public string RunBy { get; set; }
        public string RunByDisplayName { get; set; }
        public string RunById { get; set; }
        public string StartedAt { get; set; }
        public string Status { get; set; }
        public ITotals Totals { get; set; }
        
        public AutomatedTestRun Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestRun
                    {
                        Assignment = Assignment,
                        AssignmentId = AssignmentId,
                        FinishedAt = FinishedAt,
                        Id = Id,
                        ImportedAt = ImportedAt,
                        RunBy = RunBy,
                        RunByDisplayName = RunByDisplayName,
                        RunById = RunById,
                        StartedAt = StartedAt,
                        Status = Status,
                        Totals = Totals,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestRun clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestRunAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string RunId { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        
        public AutomatedTestRunAttachment Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestRunAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        RunId = RunId,
                        Size = Size,
                        SourceId = SourceId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestRunAttachment clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestRunDataTables : EtRestEntityBase 
    {
        public AutomatedTestRunDataTables()
        {
            Tables = new List<Table>();
        }

        public List<Table> Tables { get; set; }
        
        public AutomatedTestRunDataTables Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestRunDataTables
                    {
                        Tables = Tables.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestRunDataTables clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestRunIncident : EtRestEntityBase 
    {
        public Incident Incident { get; set; }
        public string IncidentId { get; set; }
        public ResultNode Node { get; set; }
        public string NodeId { get; set; }
        public AutomatedTestRun Run { get; set; }
        public string RunId { get; set; }
        
        public AutomatedTestRunIncident Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestRunIncident
                    {
                        Incident = Incident,
                        IncidentId = IncidentId,
                        Node = Node,
                        NodeId = NodeId,
                        Run = Run,
                        RunId = RunId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestRunIncident clone, bool includeLocalProperties);
    }


    public partial class AutomatedTestRunNodeAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string NodeId { get; set; }
        public string RunId { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        
        public AutomatedTestRunNodeAttachment Clone(bool includeLocalProperties)
        {
            var c = new AutomatedTestRunNodeAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        NodeId = NodeId,
                        RunId = RunId,
                        Size = Size,
                        SourceId = SourceId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(AutomatedTestRunNodeAttachment clone, bool includeLocalProperties);
    }


    public partial class BackgroundTask : EtRestEntityBase, IHasId 
    {
        public bool Complete { get; set; }
        public string Elapsed { get; set; }
        public string Error { get; set; }
        public string FinishedAt { get; set; }
        public string Id { get; set; }
        public string Message { get; set; }
        public int? ProcessedElements { get; set; }
        public double? ProgressInPercent { get; set; }
        public string StartedAt { get; set; }
        public int? TotalElements { get; set; }
        
        public BackgroundTask Clone(bool includeLocalProperties)
        {
            var c = new BackgroundTask
                    {
                        Complete = Complete,
                        Elapsed = Elapsed,
                        Error = Error,
                        FinishedAt = FinishedAt,
                        Id = Id,
                        Message = Message,
                        ProcessedElements = ProcessedElements,
                        ProgressInPercent = ProgressInPercent,
                        StartedAt = StartedAt,
                        TotalElements = TotalElements,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(BackgroundTask clone, bool includeLocalProperties);
    }


    public partial class CopyExternalSystemLink : EtRestEntityBase 
    {
        public string CopyFromLinkId { get; set; }
        public CreateExternalSystemLinkEnd Destination { get; set; }
        public string Name { get; set; }
        public CreateExternalSystemLinkEnd Source { get; set; }
        
        public CopyExternalSystemLink Clone(bool includeLocalProperties)
        {
            var c = new CopyExternalSystemLink
                    {
                        CopyFromLinkId = CopyFromLinkId,
                        Destination = Destination,
                        Name = Name,
                        Source = Source,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CopyExternalSystemLink clone, bool includeLocalProperties);
    }


    public partial class CreateAgileRunStepIncident : EtRestEntityBase 
    {
        public string IncidentId { get; set; }
        public string RunId { get; set; }
        public string StepId { get; set; }
        
        public CreateAgileRunStepIncident Clone(bool includeLocalProperties)
        {
            var c = new CreateAgileRunStepIncident
                    {
                        IncidentId = IncidentId,
                        RunId = RunId,
                        StepId = StepId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateAgileRunStepIncident clone, bool includeLocalProperties);
    }


    public partial class CreateAutomatedTestRunResultNodeIncident : EtRestEntityBase 
    {
        public string IncidentId { get; set; }
        
        public CreateAutomatedTestRunResultNodeIncident Clone(bool includeLocalProperties)
        {
            var c = new CreateAutomatedTestRunResultNodeIncident
                    {
                        IncidentId = IncidentId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateAutomatedTestRunResultNodeIncident clone, bool includeLocalProperties);
    }


    public partial class CreateBackgroundTask : EtRestEntityBase 
    {
        public object Parameters { get; set; }
        public bool? StreamProgress { get; set; }
        public string Type { get; set; }
        
        public CreateBackgroundTask Clone(bool includeLocalProperties)
        {
            var c = new CreateBackgroundTask
                    {
                        Parameters = Parameters,
                        StreamProgress = StreamProgress,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateBackgroundTask clone, bool includeLocalProperties);
    }


    public partial class CreateCustomField : EtRestEntityBase 
    {
        public CreateCustomField()
        {
            Entities = new List<string>();
            Scopes = new List<Scope>();
        }

        public string DefaultValue { get; set; }
        public string Description { get; set; }
        public List<string> Entities { get; set; }
        public string HandlerType { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public List<Scope> Scopes { get; set; }
        
        public CreateCustomField Clone(bool includeLocalProperties)
        {
            var c = new CreateCustomField
                    {
                        DefaultValue = DefaultValue,
                        Description = Description,
                        HandlerType = HandlerType,
                        Label = Label,
                        Name = Name,
                        Required = Required,
                        Entities = Entities.ToList(),
                        Scopes = Scopes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateCustomField clone, bool includeLocalProperties);
    }


    public partial class CreateExternalSystemLink : EtRestEntityBase 
    {
        public CreateExternalSystemLinkEnd Destination { get; set; }
        public bool? Enabled { get; set; }
        public string Name { get; set; }
        public CreateExternalSystemLinkEnd Source { get; set; }
        
        public CreateExternalSystemLink Clone(bool includeLocalProperties)
        {
            var c = new CreateExternalSystemLink
                    {
                        Destination = Destination,
                        Enabled = Enabled,
                        Name = Name,
                        Source = Source,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateExternalSystemLink clone, bool includeLocalProperties);
    }


    public partial class CreateExternalSystemLinkEnd : EtRestEntityBase, IHasId 
    {
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        
        public CreateExternalSystemLinkEnd Clone(bool includeLocalProperties)
        {
            var c = new CreateExternalSystemLinkEnd
                    {
                        FieldValues = FieldValues,
                        Id = Id,
                        Key = Key,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateExternalSystemLinkEnd clone, bool includeLocalProperties);
    }


    public partial class CreateMailSenderSettings : EtRestEntityBase 
    {
        public string EmailPrefix { get; set; }
        public bool Enabled { get; set; }
        public string FromAddress { get; set; }
        public string HostName { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public bool SSL { get; set; }
        public int Timeout { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        
        public CreateMailSenderSettings Clone(bool includeLocalProperties)
        {
            var c = new CreateMailSenderSettings
                    {
                        EmailPrefix = EmailPrefix,
                        Enabled = Enabled,
                        FromAddress = FromAddress,
                        HostName = HostName,
                        Password = Password,
                        Port = Port,
                        SSL = SSL,
                        Timeout = Timeout,
                        Type = Type,
                        UserName = UserName,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateMailSenderSettings clone, bool includeLocalProperties);
    }


    public partial class CreateNewRun : EtRestEntityBase 
    {
        public object FieldValues { get; set; }
        public string TesterId { get; set; }
        public object WidgetValues { get; set; }
        
        public CreateNewRun Clone(bool includeLocalProperties)
        {
            var c = new CreateNewRun
                    {
                        FieldValues = FieldValues,
                        TesterId = TesterId,
                        WidgetValues = WidgetValues,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateNewRun clone, bool includeLocalProperties);
    }


    public partial class CreateNotification : EtRestEntityBase 
    {
        public string HtmlSummary { get; set; }
        public string UserId { get; set; }
        
        public CreateNotification Clone(bool includeLocalProperties)
        {
            var c = new CreateNotification
                    {
                        HtmlSummary = HtmlSummary,
                        UserId = UserId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateNotification clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateAgileRun : EtRestEntityBase, IHasId 
    {
        public CreateOrUpdateAgileRun()
        {
            Steps = new List<AgileRunStep>();
        }

        public string ActualDuration { get; set; }
        public string AssignedToId { get; set; }
        public string Description { get; set; }
        public string EstimatedDuration { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int? Number { get; set; }
        public string Objective { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string PostCondition { get; set; }
        public string PreCondition { get; set; }
        public string PriorityId { get; set; }
        public string ProjectId { get; set; }
        public string StatusId { get; set; }
        public List<AgileRunStep> Steps { get; set; }
        public string TypeId { get; set; }
        public object WidgetValues { get; set; }
        
        public CreateOrUpdateAgileRun Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateAgileRun
                    {
                        ActualDuration = ActualDuration,
                        AssignedToId = AssignedToId,
                        Description = Description,
                        EstimatedDuration = EstimatedDuration,
                        FieldValues = FieldValues,
                        Id = Id,
                        Name = Name,
                        Notes = Notes,
                        Number = Number,
                        Objective = Objective,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        PostCondition = PostCondition,
                        PreCondition = PreCondition,
                        PriorityId = PriorityId,
                        ProjectId = ProjectId,
                        StatusId = StatusId,
                        TypeId = TypeId,
                        WidgetValues = WidgetValues,
                        Steps = Steps.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateAgileRun clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateAutomatedTest : EtRestEntityBase, IHasId 
    {
        public string AssignedToId { get; set; }
        public object Configuration { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string Type { get; set; }
        
        public CreateOrUpdateAutomatedTest Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateAutomatedTest
                    {
                        AssignedToId = AssignedToId,
                        Configuration = Configuration,
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateAutomatedTest clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateAutomatedTestAssignment : EtRestEntityBase, IHasId 
    {
        public string AssignedToId { get; set; }
        public string AutomatedTestId { get; set; }
        public string Id { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        
        public CreateOrUpdateAutomatedTestAssignment Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateAutomatedTestAssignment
                    {
                        AssignedToId = AssignedToId,
                        AutomatedTestId = AutomatedTestId,
                        Id = Id,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateAutomatedTestAssignment clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateExecutionPackage : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string ParentId { get; set; }
        public string ProjectId { get; set; }
        public string Stereotype { get; set; }
        
        public CreateOrUpdateExecutionPackage Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateExecutionPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        ParentId = ParentId,
                        ProjectId = ProjectId,
                        Stereotype = Stereotype,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateExecutionPackage clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateExternalSystem : EtRestEntityBase 
    {
        public bool? Enabled { get; set; }
        public object FieldValues { get; set; }
        public string Name { get; set; }
        public string OrganisationId { get; set; }
        public string Type { get; set; }
        
        public CreateOrUpdateExternalSystem Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateExternalSystem
                    {
                        Enabled = Enabled,
                        FieldValues = FieldValues,
                        Name = Name,
                        OrganisationId = OrganisationId,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateExternalSystem clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateGroup : EtRestEntityBase, IHasId 
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        
        public CreateOrUpdateGroup Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateGroup
                    {
                        Description = Description,
                        Id = Id,
                        Name = Name,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateGroup clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateIncident : EtRestEntityBase, IHasId 
    {
        public CreateOrUpdateIncident()
        {
            AffectedVersionIds = new List<string>();
            Comments = new List<CreateOrUpdateIncidentComment>();
            ComponentIds = new List<string>();
            ExternalSystemLinkIds = new List<string>();
            ExternalSystemLinks = new List<IdOrName>();
            FixedVersionIds = new List<string>();
        }

        public List<string> AffectedVersionIds { get; set; }
        public string AssignedToId { get; set; }
        public List<CreateOrUpdateIncidentComment> Comments { get; set; }
        public List<string> ComponentIds { get; set; }
        public string Description { get; set; }
        public List<string> ExternalSystemLinkIds { get; set; }
        public List<IdOrName> ExternalSystemLinks { get; set; }
        public object FieldValues { get; set; }
        public List<string> FixedVersionIds { get; set; }
        public string Id { get; set; }
        public int? Number { get; set; }
        public string PriorityId { get; set; }
        public string ProjectId { get; set; }
        public string ResolutionId { get; set; }
        public string StatusId { get; set; }
        public string Summary { get; set; }
        public string TemporaryId { get; set; }
        public string TypeId { get; set; }
        public object WidgetValues { get; set; }
        
        public CreateOrUpdateIncident Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateIncident
                    {
                        AssignedToId = AssignedToId,
                        Description = Description,
                        FieldValues = FieldValues,
                        Id = Id,
                        Number = Number,
                        PriorityId = PriorityId,
                        ProjectId = ProjectId,
                        ResolutionId = ResolutionId,
                        StatusId = StatusId,
                        Summary = Summary,
                        TemporaryId = TemporaryId,
                        TypeId = TypeId,
                        WidgetValues = WidgetValues,
                        AffectedVersionIds = AffectedVersionIds.ToList(),
                        Comments = Comments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ComponentIds = ComponentIds.ToList(),
                        ExternalSystemLinkIds = ExternalSystemLinkIds.ToList(),
                        ExternalSystemLinks = ExternalSystemLinks.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        FixedVersionIds = FixedVersionIds.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateIncident clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateIncidentComment : EtRestEntityBase, IHasId 
    {
        public string Body { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedById { get; set; }
        public string TicketCommentId { get; set; }
        
        public CreateOrUpdateIncidentComment Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateIncidentComment
                    {
                        Body = Body,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedById = LastUpdatedById,
                        TicketCommentId = TicketCommentId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateIncidentComment clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateOrganisation : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string IndustryType { get; set; }
        public string LongDescription { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string ShortDescription { get; set; }
        
        public CreateOrUpdateOrganisation Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateOrganisation
                    {
                        Id = Id,
                        IndustryType = IndustryType,
                        LongDescription = LongDescription,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        ShortDescription = ShortDescription,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateOrganisation clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdatePermissionAssignment : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Key { get; set; }
        
        public CreateOrUpdatePermissionAssignment Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdatePermissionAssignment
                    {
                        Id = Id,
                        Key = Key,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdatePermissionAssignment clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateProject : EtRestEntityBase, IHasId 
    {
        public bool? AutoNumberRequirements { get; set; }
        public bool? AutoNumberScripts { get; set; }
        public string Description { get; set; }
        public string EstimatedEndDate { get; set; }
        public string Id { get; set; }
        public bool? Independent { get; set; }
        public bool? Linked { get; set; }
        public string ManagerId { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string OrganisationId { get; set; }
        public string ProjectCategoryId { get; set; }
        public string ProjectTypeId { get; set; }
        public bool? RequirementNumberReadOnly { get; set; }
        public bool? ScriptNumberReadOnly { get; set; }
        public string Slug { get; set; }
        public string StartDate { get; set; }
        public string TemplateId { get; set; }
        public TimeTrackingConfiguration TimeTrackingConfiguration { get; set; }
        
        public CreateOrUpdateProject Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateProject
                    {
                        AutoNumberRequirements = AutoNumberRequirements,
                        AutoNumberScripts = AutoNumberScripts,
                        Description = Description,
                        EstimatedEndDate = EstimatedEndDate,
                        Id = Id,
                        Independent = Independent,
                        Linked = Linked,
                        ManagerId = ManagerId,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        OrganisationId = OrganisationId,
                        ProjectCategoryId = ProjectCategoryId,
                        ProjectTypeId = ProjectTypeId,
                        RequirementNumberReadOnly = RequirementNumberReadOnly,
                        ScriptNumberReadOnly = ScriptNumberReadOnly,
                        Slug = Slug,
                        StartDate = StartDate,
                        TemplateId = TemplateId,
                        TimeTrackingConfiguration = TimeTrackingConfiguration,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateProject clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateProjectCategory : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string OrganisationId { get; set; }
        public string ParentId { get; set; }
        
        public CreateOrUpdateProjectCategory Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateProjectCategory
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        OrganisationId = OrganisationId,
                        ParentId = ParentId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateProjectCategory clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateRequirement : EtRestEntityBase, IHasId 
    {
        public string AssignedToId { get; set; }
        public string ChangeComment { get; set; }
        public string Description { get; set; }
        public string DifficultyLevelId { get; set; }
        public string EstimatedDuration { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public object Number { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string ParentId { get; set; }
        public string PriorityId { get; set; }
        public string StatusId { get; set; }
        public string TemporaryId { get; set; }
        public string TypeId { get; set; }
        public object WidgetValues { get; set; }
        
        public CreateOrUpdateRequirement Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateRequirement
                    {
                        AssignedToId = AssignedToId,
                        ChangeComment = ChangeComment,
                        Description = Description,
                        DifficultyLevelId = DifficultyLevelId,
                        EstimatedDuration = EstimatedDuration,
                        FieldValues = FieldValues,
                        Id = Id,
                        Name = Name,
                        Number = Number,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        ParentId = ParentId,
                        PriorityId = PriorityId,
                        StatusId = StatusId,
                        TemporaryId = TemporaryId,
                        TypeId = TypeId,
                        WidgetValues = WidgetValues,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateRequirement clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateRequirementPackage : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string ParentId { get; set; }
        public string ProjectId { get; set; }
        
        public CreateOrUpdateRequirementPackage Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateRequirementPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        ParentId = ParentId,
                        ProjectId = ProjectId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateRequirementPackage clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateScript : EtRestEntityBase, IHasId 
    {
        public CreateOrUpdateScript()
        {
            Steps = new List<Step>();
        }

        public string AssignedToId { get; set; }
        public string ChangeComment { get; set; }
        public string Description { get; set; }
        public string EstimatedDuration { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public object Number { get; set; }
        public string Objective { get; set; }
        public int? OrderNumber { get; set; }
        public string PackageId { get; set; }
        public string PostCondition { get; set; }
        public string PreCondition { get; set; }
        public string PriorityId { get; set; }
        public string StatusId { get; set; }
        public List<Step> Steps { get; set; }
        public string TemporaryId { get; set; }
        public string TypeId { get; set; }
        public object WidgetValues { get; set; }
        
        public CreateOrUpdateScript Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateScript
                    {
                        AssignedToId = AssignedToId,
                        ChangeComment = ChangeComment,
                        Description = Description,
                        EstimatedDuration = EstimatedDuration,
                        FieldValues = FieldValues,
                        Id = Id,
                        Name = Name,
                        Notes = Notes,
                        Number = Number,
                        Objective = Objective,
                        OrderNumber = OrderNumber,
                        PackageId = PackageId,
                        PostCondition = PostCondition,
                        PreCondition = PreCondition,
                        PriorityId = PriorityId,
                        StatusId = StatusId,
                        TemporaryId = TemporaryId,
                        TypeId = TypeId,
                        WidgetValues = WidgetValues,
                        Steps = Steps.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateScript clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateScriptAssignment : EtRestEntityBase, IHasId 
    {
        public string AssignedToId { get; set; }
        public string Id { get; set; }
        public string PackageId { get; set; }
        public string ScriptId { get; set; }
        
        public CreateOrUpdateScriptAssignment Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateScriptAssignment
                    {
                        AssignedToId = AssignedToId,
                        Id = Id,
                        PackageId = PackageId,
                        ScriptId = ScriptId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateScriptAssignment clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateScriptPackage : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? OrderNumber { get; set; }
        public string ParentId { get; set; }
        public string ProjectId { get; set; }
        
        public CreateOrUpdateScriptPackage Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateScriptPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        ParentId = ParentId,
                        ProjectId = ProjectId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateScriptPackage clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateSynchronizationScheduleInfo : EtRestEntityBase, IHasId 
    {
        public string Condition { get; set; }
        public SynchronizationScheduleConfiguration Configuration { get; set; }
        public string Direction { get; set; }
        public bool Enabled { get; set; }
        public string Id { get; set; }
        public string LinkId { get; set; }
        public string Scope { get; set; }
        
        public CreateOrUpdateSynchronizationScheduleInfo Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateSynchronizationScheduleInfo
                    {
                        Condition = Condition,
                        Configuration = Configuration,
                        Direction = Direction,
                        Enabled = Enabled,
                        Id = Id,
                        LinkId = LinkId,
                        Scope = Scope,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateSynchronizationScheduleInfo clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateSystemEvent : EtRestEntityBase, IHasId 
    {
        public string DocumentId { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string Id { get; set; }
        public string Level { get; set; }
        public string LinkId { get; set; }
        public string Message { get; set; }
        public string OccurredAt { get; set; }
        public string ReferenceId { get; set; }
        public string Source { get; set; }
        public string SystemId { get; set; }
        public string Type { get; set; }
        
        public CreateOrUpdateSystemEvent Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateSystemEvent
                    {
                        DocumentId = DocumentId,
                        EntityId = EntityId,
                        EntityType = EntityType,
                        Id = Id,
                        Level = Level,
                        LinkId = LinkId,
                        Message = Message,
                        OccurredAt = OccurredAt,
                        ReferenceId = ReferenceId,
                        Source = Source,
                        SystemId = SystemId,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateSystemEvent clone, bool includeLocalProperties);
    }


    public partial class CreateOrUpdateUser : EtRestEntityBase, IHasId 
    {
        public string Email { get; set; }
        public bool? Enabled { get; set; }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public bool? IsExternal { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        
        public CreateOrUpdateUser Clone(bool includeLocalProperties)
        {
            var c = new CreateOrUpdateUser
                    {
                        Email = Email,
                        Enabled = Enabled,
                        FirstName = FirstName,
                        Id = Id,
                        IsExternal = IsExternal,
                        LastName = LastName,
                        Password = Password,
                        Phone = Phone,
                        UserName = UserName,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateOrUpdateUser clone, bool includeLocalProperties);
    }


    public partial class CreateRelationship : EtRestEntityBase 
    {
        public string DestinationEntityId { get; set; }
        public string DestinationEntityType { get; set; }
        public string RelationshipDirection { get; set; }
        public string SourceEntityId { get; set; }
        public string SourceEntityType { get; set; }
        
        public CreateRelationship Clone(bool includeLocalProperties)
        {
            var c = new CreateRelationship
                    {
                        DestinationEntityId = DestinationEntityId,
                        DestinationEntityType = DestinationEntityType,
                        RelationshipDirection = RelationshipDirection,
                        SourceEntityId = SourceEntityId,
                        SourceEntityType = SourceEntityType,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateRelationship clone, bool includeLocalProperties);
    }


    public partial class CreateStepRunResultIncident : EtRestEntityBase 
    {
        public string IncidentId { get; set; }
        public string StepResultId { get; set; }
        
        public CreateStepRunResultIncident Clone(bool includeLocalProperties)
        {
            var c = new CreateStepRunResultIncident
                    {
                        IncidentId = IncidentId,
                        StepResultId = StepResultId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CreateStepRunResultIncident clone, bool includeLocalProperties);
    }


    public partial class CusField : EtRestEntityBase 
    {
        public Set set { get; set; }
        
        public CusField Clone(bool includeLocalProperties)
        {
            var c = new CusField
                    {
                        set = set,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CusField clone, bool includeLocalProperties);
    }


    public partial class CustomField : EtRestEntityBase, IHasId 
    {
        public CustomField()
        {
            Entities = new List<string>();
            Scopes = new List<Scope>();
        }

        public string CustomFieldTypeName { get; set; }
        public string Description { get; set; }
        public List<string> Entities { get; set; }
        public string Id { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public List<Scope> Scopes { get; set; }
        
        public CustomField Clone(bool includeLocalProperties)
        {
            var c = new CustomField
                    {
                        CustomFieldTypeName = CustomFieldTypeName,
                        Description = Description,
                        Id = Id,
                        Label = Label,
                        Name = Name,
                        Required = Required,
                        Entities = Entities.ToList(),
                        Scopes = Scopes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CustomField clone, bool includeLocalProperties);
    }


    public partial class CustomFieldType : EtRestEntityBase 
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }
        
        public CustomFieldType Clone(bool includeLocalProperties)
        {
            var c = new CustomFieldType
                    {
                        DisplayName = DisplayName,
                        Name = Name,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(CustomFieldType clone, bool includeLocalProperties);
    }


    public partial class EditExternalSystemLink : EtRestEntityBase, IHasId 
    {
        public bool? Enabled { get; set; }
        public string Id { get; set; }
        
        public EditExternalSystemLink Clone(bool includeLocalProperties)
        {
            var c = new EditExternalSystemLink
                    {
                        Enabled = Enabled,
                        Id = Id,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(EditExternalSystemLink clone, bool includeLocalProperties);
    }


    public partial class EditGridWidgetState : EtRestEntityBase 
    {
        public object Data { get; set; }
        public string WidgetType { get; set; }
        
        public EditGridWidgetState Clone(bool includeLocalProperties)
        {
            var c = new EditGridWidgetState
                    {
                        Data = Data,
                        WidgetType = WidgetType,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(EditGridWidgetState clone, bool includeLocalProperties);
    }


    public partial class EditResultNode : EtRestEntityBase 
    {
        public string Notes { get; set; }
        
        public EditResultNode Clone(bool includeLocalProperties)
        {
            var c = new EditResultNode
                    {
                        Notes = Notes,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(EditResultNode clone, bool includeLocalProperties);
    }


    public partial class EntityTypeWidgets : EtRestEntityBase 
    {
        public EntityWidgets AgileRun { get; set; }
        public EntityWidgets Incident { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public EntityWidgets Requirement { get; set; }
        public EntityWidgets ScriptRun { get; set; }
        public EntityWidgets TestScript { get; set; }
        
        public EntityTypeWidgets Clone(bool includeLocalProperties)
        {
            var c = new EntityTypeWidgets
                    {
                        AgileRun = AgileRun,
                        Incident = Incident,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        Requirement = Requirement,
                        ScriptRun = ScriptRun,
                        TestScript = TestScript,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(EntityTypeWidgets clone, bool includeLocalProperties);
    }


    public partial class EntityWidgets : EtRestEntityBase 
    {
        public EntityWidgets()
        {
            Widgets = new List<AbstractWidget>();
        }

        public string EntityType { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public EntityWidgets Clone(bool includeLocalProperties)
        {
            var c = new EntityWidgets
                    {
                        EntityType = EntityType,
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(EntityWidgets clone, bool includeLocalProperties);
    }


    public partial class ExecutionPackage : EtRestEntityBase, IHasId 
    {
        public ExecutionPackage()
        {
            AgileRuns = new List<AgileRun>();
            AutomatedTestAssignments = new List<AutomatedTestAssignment>();
            Children = new List<ExecutionPackage>();
            ScriptAssignments = new List<ScriptAssignment>();
        }

        public List<AgileRun> AgileRuns { get; set; }
        public List<AutomatedTestAssignment> AutomatedTestAssignments { get; set; }
        public List<ExecutionPackage> Children { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public ExecutionPackage Parent { get; set; }
        public string ParentId { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public List<ScriptAssignment> ScriptAssignments { get; set; }
        public string Stereotype { get; set; }
        
        public ExecutionPackage Clone(bool includeLocalProperties)
        {
            var c = new ExecutionPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        Parent = Parent,
                        ParentId = ParentId,
                        Project = Project,
                        ProjectId = ProjectId,
                        Stereotype = Stereotype,
                        AgileRuns = AgileRuns.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        AutomatedTestAssignments = AutomatedTestAssignments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ScriptAssignments = ScriptAssignments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExecutionPackage clone, bool includeLocalProperties);
    }


    public partial class ExternalSourceMetadata : EtRestEntityBase, IHasId 
    {
        public ExternalSourceMetadata()
        {
            CompatibleWithSourceKeys = new List<string>();
        }

        public List<string> CompatibleWithSourceKeys { get; set; }
        public string End { get; set; }
        public string Id { get; set; }
        public Object InitialFieldValues { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public Object Widgets { get; set; }
        
        public ExternalSourceMetadata Clone(bool includeLocalProperties)
        {
            var c = new ExternalSourceMetadata
                    {
                        End = End,
                        Id = Id,
                        InitialFieldValues = InitialFieldValues,
                        Key = Key,
                        Name = Name,
                        Widgets = Widgets,
                        CompatibleWithSourceKeys = CompatibleWithSourceKeys.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExternalSourceMetadata clone, bool includeLocalProperties);
    }


    public partial class ExternalSystem : EtRestEntityBase, IHasId 
    {
        public ExternalSystem()
        {
            AdditionalConfigurationLinks = new List<Link>();
            Categories = new List<string>();
            ConfigurationProblems = new List<string>();
            ExternalSystemLinks = new List<ExternalSystemLink>();
            Widgets = new List<object>();
        }

        public List<Link> AdditionalConfigurationLinks { get; set; }
        public List<string> Categories { get; set; }
        public string Configuration { get; set; }
        public bool ConfigurationComplete { get; set; }
        public List<string> ConfigurationProblems { get; set; }
        public string ConnectionString { get; set; }
        public string ConnectionType { get; set; }
        public bool Enabled { get; set; }
        public List<ExternalSystemLink> ExternalSystemLinks { get; set; }
        public object FieldValues { get; set; }
        public bool HasPassword { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int NumberOfLinks { get; set; }
        public string OrganisationId { get; set; }
        public string QualifiedName { get; set; }
        public string Type { get; set; }
        public string TypeDescription { get; set; }
        public string UserName { get; set; }
        public List<object> Widgets { get; set; }
        
        public ExternalSystem Clone(bool includeLocalProperties)
        {
            var c = new ExternalSystem
                    {
                        Configuration = Configuration,
                        ConfigurationComplete = ConfigurationComplete,
                        ConnectionString = ConnectionString,
                        ConnectionType = ConnectionType,
                        Enabled = Enabled,
                        FieldValues = FieldValues,
                        HasPassword = HasPassword,
                        Id = Id,
                        Name = Name,
                        NumberOfLinks = NumberOfLinks,
                        OrganisationId = OrganisationId,
                        QualifiedName = QualifiedName,
                        Type = Type,
                        TypeDescription = TypeDescription,
                        UserName = UserName,
                        AdditionalConfigurationLinks = AdditionalConfigurationLinks.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Categories = Categories.ToList(),
                        ConfigurationProblems = ConfigurationProblems.ToList(),
                        ExternalSystemLinks = ExternalSystemLinks.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Widgets = Widgets.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExternalSystem clone, bool includeLocalProperties);
    }


    public partial class ExternalSystemComment : EtRestEntityBase, IHasId 
    {
        public string Body { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ExternalSystemLinkId { get; set; }
        public string Id { get; set; }
        public string TicketId { get; set; }
        
        public ExternalSystemComment Clone(bool includeLocalProperties)
        {
            var c = new ExternalSystemComment
                    {
                        Body = Body,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        ExternalSystemLinkId = ExternalSystemLinkId,
                        Id = Id,
                        TicketId = TicketId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExternalSystemComment clone, bool includeLocalProperties);
    }


    public partial class ExternalSystemLink : EtRestEntityBase, IHasId 
    {
        public ExternalSystemLink()
        {
            ConfigurationProblems = new List<string>();
        }

        public string AutoSelect { get; set; }
        public string Configuration { get; set; }
        public bool ConfigurationComplete { get; set; }
        public List<string> ConfigurationProblems { get; set; }
        public string DefectTrackerProjectId { get; set; }
        public string EaPackageId { get; set; }
        public bool Enabled { get; set; }
        public ExternalSystem ExternalSystem { get; set; }
        public string ExternalSystemConnectionType { get; set; }
        public string ExternalSystemId { get; set; }
        public string ExternalSystemImplementationType { get; set; }
        public string ExternalSystemName { get; set; }
        public string Id { get; set; }
        public string InternalPackageName { get; set; }
        public string LastDestinationToSourceSynchronizationAt { get; set; }
        public string LastSourceToDestinationSynchronizationAt { get; set; }
        public string LastSynchronizedAt { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string RequirementPackageId { get; set; }
        public string TestExecutionPackageId { get; set; }
        public string TestScriptPackageId { get; set; }
        public string Type { get; set; }
        public string TypeForDisplay { get; set; }
        
        public ExternalSystemLink Clone(bool includeLocalProperties)
        {
            var c = new ExternalSystemLink
                    {
                        AutoSelect = AutoSelect,
                        Configuration = Configuration,
                        ConfigurationComplete = ConfigurationComplete,
                        DefectTrackerProjectId = DefectTrackerProjectId,
                        EaPackageId = EaPackageId,
                        Enabled = Enabled,
                        ExternalSystem = ExternalSystem,
                        ExternalSystemConnectionType = ExternalSystemConnectionType,
                        ExternalSystemId = ExternalSystemId,
                        ExternalSystemImplementationType = ExternalSystemImplementationType,
                        ExternalSystemName = ExternalSystemName,
                        Id = Id,
                        InternalPackageName = InternalPackageName,
                        LastDestinationToSourceSynchronizationAt = LastDestinationToSourceSynchronizationAt,
                        LastSourceToDestinationSynchronizationAt = LastSourceToDestinationSynchronizationAt,
                        LastSynchronizedAt = LastSynchronizedAt,
                        Name = Name,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        RequirementPackageId = RequirementPackageId,
                        TestExecutionPackageId = TestExecutionPackageId,
                        TestScriptPackageId = TestScriptPackageId,
                        Type = Type,
                        TypeForDisplay = TypeForDisplay,
                        ConfigurationProblems = ConfigurationProblems.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExternalSystemLink clone, bool includeLocalProperties);
    }


    public partial class ExternalSystemType : EtRestEntityBase, IHasId 
    {
        public ExternalSystemType()
        {
            Categories = new List<string>();
        }

        public List<string> Categories { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        
        public ExternalSystemType Clone(bool includeLocalProperties)
        {
            var c = new ExternalSystemType
                    {
                        Id = Id,
                        Name = Name,
                        Categories = Categories.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ExternalSystemType clone, bool includeLocalProperties);
    }


    public partial class GridWidgetContext : EtRestEntityBase 
    {
        public GridWidgetContext()
        {
            AllowableTypes = new List<string>();
            Selections = new List<TypedId>();
        }

        public List<string> AllowableTypes { get; set; }
        public string BaseQuery { get; set; }
        public string IndexName { get; set; }
        public string PackageId { get; set; }
        public string PackageType { get; set; }
        public object Parameters { get; set; }
        public string ProjectId { get; set; }
        public string Query { get; set; }
        public List<TypedId> Selections { get; set; }
        public string TimeZone { get; set; }
        
        public GridWidgetContext Clone(bool includeLocalProperties)
        {
            var c = new GridWidgetContext
                    {
                        BaseQuery = BaseQuery,
                        IndexName = IndexName,
                        PackageId = PackageId,
                        PackageType = PackageType,
                        Parameters = Parameters,
                        ProjectId = ProjectId,
                        Query = Query,
                        TimeZone = TimeZone,
                        AllowableTypes = AllowableTypes.ToList(),
                        Selections = Selections.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GridWidgetContext clone, bool includeLocalProperties);
    }


    public partial class GridWidgetData : EtRestEntityBase 
    {
        public object Data { get; set; }
        
        public GridWidgetData Clone(bool includeLocalProperties)
        {
            var c = new GridWidgetData
                    {
                        Data = Data,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GridWidgetData clone, bool includeLocalProperties);
    }


    public partial class GridWidgetState : EtRestEntityBase 
    {
        public object Data { get; set; }
        public string Position { get; set; }
        public string WidgetType { get; set; }
        
        public GridWidgetState Clone(bool includeLocalProperties)
        {
            var c = new GridWidgetState
                    {
                        Data = Data,
                        Position = Position,
                        WidgetType = WidgetType,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GridWidgetState clone, bool includeLocalProperties);
    }


    public partial class GridWidgetStateSet : EtRestEntityBase 
    {
        public string HostId { get; set; }
        public object Positions { get; set; }
        
        public GridWidgetStateSet Clone(bool includeLocalProperties)
        {
            var c = new GridWidgetStateSet
                    {
                        HostId = HostId,
                        Positions = Positions,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GridWidgetStateSet clone, bool includeLocalProperties);
    }


    public partial class Group : EtRestEntityBase, IHasId 
    {
        public Group()
        {
            Users = new List<User>();
        }

        public string Description { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
        
        public Group Clone(bool includeLocalProperties)
        {
            var c = new Group
                    {
                        Description = Description,
                        Id = Id,
                        Name = Name,
                        Users = Users.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Group clone, bool includeLocalProperties);
    }


    public partial class GroupMembership : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        
        public GroupMembership Clone(bool includeLocalProperties)
        {
            var c = new GroupMembership
                    {
                        Id = Id,
                        UserName = UserName,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GroupMembership clone, bool includeLocalProperties);
    }


    public partial class GroupMemberships : EtRestEntityBase 
    {
        public GroupMemberships()
        {
            Items = new List<GroupMembership>();
        }

        public List<GroupMembership> Items { get; set; }
        
        public GroupMemberships Clone(bool includeLocalProperties)
        {
            var c = new GroupMemberships
                    {
                        Items = Items.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GroupMemberships clone, bool includeLocalProperties);
    }


    public partial class GroupPermissionProject : EtRestEntityBase 
    {
        public string ProjectId { get; set; }
        
        public GroupPermissionProject Clone(bool includeLocalProperties)
        {
            var c = new GroupPermissionProject
                    {
                        ProjectId = ProjectId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GroupPermissionProject clone, bool includeLocalProperties);
    }


    public partial class GroupPermissionProjects : EtRestEntityBase 
    {
        public GroupPermissionProjects()
        {
            Projects = new List<GroupPermissionProject>();
        }

        public List<GroupPermissionProject> Projects { get; set; }
        
        public GroupPermissionProjects Clone(bool includeLocalProperties)
        {
            var c = new GroupPermissionProjects
                    {
                        Projects = Projects.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(GroupPermissionProjects clone, bool includeLocalProperties);
    }


    public partial class IdOrName : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public IdOrName Clone(bool includeLocalProperties)
        {
            var c = new IdOrName
                    {
                        Id = Id,
                        Name = Name,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(IdOrName clone, bool includeLocalProperties);
    }


    public partial class INamedEntity : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        
        public INamedEntity Clone(bool includeLocalProperties)
        {
            var c = new INamedEntity
                    {
                        Id = Id,
                        Name = Name,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(INamedEntity clone, bool includeLocalProperties);
    }


    public partial class Incident : EtRestEntityBase, IHasId 
    {
        public Incident()
        {
            AffectedVersionIds = new List<string>();
            Attachments = new List<IncidentAttachment>();
            Comments = new List<IncidentComment>();
            ComponentIds = new List<string>();
            ExternalSystemLinkIds = new List<string>();
            ExternalSystemLinks = new List<ExternalSystemLink>();
            FixedVersionIds = new List<string>();
            Widgets = new List<AbstractWidget>();
        }

        public List<string> AffectedVersionIds { get; set; }
        public PicklistCollection AffectedVersions { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public List<IncidentAttachment> Attachments { get; set; }
        public List<IncidentComment> Comments { get; set; }
        public List<string> ComponentIds { get; set; }
        public PicklistCollection Components { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string Description { get; set; }
        public string ExternalKeys { get; set; }
        public List<string> ExternalSystemLinkIds { get; set; }
        public List<ExternalSystemLink> ExternalSystemLinks { get; set; }
        public object FieldValues { get; set; }
        public List<string> FixedVersionIds { get; set; }
        public PicklistCollection FixedVersions { get; set; }
        public bool HasAttachments { get; set; }
        public string Id { get; set; }
        public int IncidentNumber { get; set; }
        public string InternalId { get; set; }
        public IncidentComment LastComment { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedById { get; set; }
        public Picklist Priority { get; set; }
        public string PriorityId { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Picklist Resolution { get; set; }
        public string ResolutionId { get; set; }
        public Picklist Status { get; set; }
        public string StatusId { get; set; }
        public string Summary { get; set; }
        public Picklist Type { get; set; }
        public string TypeId { get; set; }
        public int VersionNumber { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public Incident Clone(bool includeLocalProperties)
        {
            var c = new Incident
                    {
                        AffectedVersions = AffectedVersions,
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        Components = Components,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        CreatedById = CreatedById,
                        Description = Description,
                        ExternalKeys = ExternalKeys,
                        FieldValues = FieldValues,
                        FixedVersions = FixedVersions,
                        HasAttachments = HasAttachments,
                        Id = Id,
                        IncidentNumber = IncidentNumber,
                        InternalId = InternalId,
                        LastComment = LastComment,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedBy = LastUpdatedBy,
                        LastUpdatedById = LastUpdatedById,
                        Priority = Priority,
                        PriorityId = PriorityId,
                        Project = Project,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        Resolution = Resolution,
                        ResolutionId = ResolutionId,
                        Status = Status,
                        StatusId = StatusId,
                        Summary = Summary,
                        Type = Type,
                        TypeId = TypeId,
                        VersionNumber = VersionNumber,
                        AffectedVersionIds = AffectedVersionIds.ToList(),
                        Attachments = Attachments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Comments = Comments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ComponentIds = ComponentIds.ToList(),
                        ExternalSystemLinkIds = ExternalSystemLinkIds.ToList(),
                        ExternalSystemLinks = ExternalSystemLinks.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        FixedVersionIds = FixedVersionIds.ToList(),
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Incident clone, bool includeLocalProperties);
    }


    public partial class IncidentAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string IncidentId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        
        public IncidentAttachment Clone(bool includeLocalProperties)
        {
            var c = new IncidentAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        IncidentId = IncidentId,
                        Name = Name,
                        Size = Size,
                        SourceId = SourceId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(IncidentAttachment clone, bool includeLocalProperties);
    }


    public partial class IncidentComment : EtRestEntityBase, IHasId 
    {
        public string Body { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByUserName { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedById { get; set; }
        public string LastUpdatedByUserName { get; set; }
        
        public IncidentComment Clone(bool includeLocalProperties)
        {
            var c = new IncidentComment
                    {
                        Body = Body,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        CreatedByUserName = CreatedByUserName,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedById = LastUpdatedById,
                        LastUpdatedByUserName = LastUpdatedByUserName,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(IncidentComment clone, bool includeLocalProperties);
    }


    public partial class IndexMetadata : EtRestEntityBase 
    {
        public IndexMetadata()
        {
            SupportedTypes = new List<string>();
        }

        public string IndexName { get; set; }
        public bool IsPresentable { get; set; }
        public List<string> SupportedTypes { get; set; }
        
        public IndexMetadata Clone(bool includeLocalProperties)
        {
            var c = new IndexMetadata
                    {
                        IndexName = IndexName,
                        IsPresentable = IsPresentable,
                        SupportedTypes = SupportedTypes.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(IndexMetadata clone, bool includeLocalProperties);
    }


    public partial class ITotals : EtRestEntityBase 
    {
        public int Done { get; set; }
        public int Errors { get; set; }
        public int Failed { get; set; }
        public int Infos { get; set; }
        public int Iterations { get; set; }
        public int NotRun { get; set; }
        public int Passed { get; set; }
        public int Skipped { get; set; }
        public int TotalNodes { get; set; }
        public int TotalResults { get; set; }
        public int Warnings { get; set; }
        
        public ITotals Clone(bool includeLocalProperties)
        {
            var c = new ITotals
                    {
                        Done = Done,
                        Errors = Errors,
                        Failed = Failed,
                        Infos = Infos,
                        Iterations = Iterations,
                        NotRun = NotRun,
                        Passed = Passed,
                        Skipped = Skipped,
                        TotalNodes = TotalNodes,
                        TotalResults = TotalResults,
                        Warnings = Warnings,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ITotals clone, bool includeLocalProperties);
    }


    public partial class IValue : EtRestEntityBase 
    {
        public IValue()
        {
            Children = new List<IValue>();
        }

        public List<IValue> Children { get; set; }
        public string Icon { get; set; }
        public string Identifier { get; set; }
        public IValue Parent { get; set; }
        public string Text { get; set; }
        
        public IValue Clone(bool includeLocalProperties)
        {
            var c = new IValue
                    {
                        Icon = Icon,
                        Identifier = Identifier,
                        Parent = Parent,
                        Text = Text,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(IValue clone, bool includeLocalProperties);
    }


    public partial class Link : EtRestEntityBase 
    {
        public string Href { get; set; }
        public bool Inline { get; set; }
        public string Rel { get; set; }
        public string Title { get; set; }
        
        public Link Clone(bool includeLocalProperties)
        {
            var c = new Link
                    {
                        Href = Href,
                        Inline = Inline,
                        Rel = Rel,
                        Title = Title,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Link clone, bool includeLocalProperties);
    }


    public partial class MailAddress : EtRestEntityBase 
    {
        public string Address { get; set; }
        public string Name { get; set; }
        
        public MailAddress Clone(bool includeLocalProperties)
        {
            var c = new MailAddress
                    {
                        Address = Address,
                        Name = Name,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(MailAddress clone, bool includeLocalProperties);
    }


    public partial class MailSenderSettings : EtRestEntityBase 
    {
        public string EmailPrefix { get; set; }
        public bool Enabled { get; set; }
        public string ErrorMessage { get; set; }
        public string FromAddress { get; set; }
        public string HostName { get; set; }
        public bool? IsValid { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public bool SSL { get; set; }
        public int Timeout { get; set; }
        public string Type { get; set; }
        public string UserName { get; set; }
        
        public MailSenderSettings Clone(bool includeLocalProperties)
        {
            var c = new MailSenderSettings
                    {
                        EmailPrefix = EmailPrefix,
                        Enabled = Enabled,
                        ErrorMessage = ErrorMessage,
                        FromAddress = FromAddress,
                        HostName = HostName,
                        IsValid = IsValid,
                        Password = Password,
                        Port = Port,
                        SSL = SSL,
                        Timeout = Timeout,
                        Type = Type,
                        UserName = UserName,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(MailSenderSettings clone, bool includeLocalProperties);
    }


    public partial class Message : EtRestEntityBase 
    {
        public Message()
        {
            To = new List<MailAddress>();
        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public List<MailAddress> To { get; set; }
        
        public Message Clone(bool includeLocalProperties)
        {
            var c = new Message
                    {
                        Body = Body,
                        Subject = Subject,
                        To = To.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Message clone, bool includeLocalProperties);
    }


    public partial class ModuleInfo : EtRestEntityBase 
    {
        public string Description { get; set; }
        public string LoadStatus { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public bool SupportsStateChange { get; set; }
        public string TypeName { get; set; }
        public string VendorName { get; set; }
        public string VendorUrl { get; set; }
        public string Version { get; set; }
        
        public ModuleInfo Clone(bool includeLocalProperties)
        {
            var c = new ModuleInfo
                    {
                        Description = Description,
                        LoadStatus = LoadStatus,
                        Name = Name,
                        State = State,
                        SupportsStateChange = SupportsStateChange,
                        TypeName = TypeName,
                        VendorName = VendorName,
                        VendorUrl = VendorUrl,
                        Version = Version,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ModuleInfo clone, bool includeLocalProperties);
    }


    public partial class NotificationMessage : EtRestEntityBase, IHasId 
    {
        public string HtmlSummary { get; set; }
        public string IconClass { get; set; }
        public string IconTitle { get; set; }
        public string Id { get; set; }
        public string OccurredAt { get; set; }
        public bool Viewed { get; set; }
        
        public NotificationMessage Clone(bool includeLocalProperties)
        {
            var c = new NotificationMessage
                    {
                        HtmlSummary = HtmlSummary,
                        IconClass = IconClass,
                        IconTitle = IconTitle,
                        Id = Id,
                        OccurredAt = OccurredAt,
                        Viewed = Viewed,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(NotificationMessage clone, bool includeLocalProperties);
    }


    public partial class Object : EtRestEntityBase 
    {
        
        public Object Clone(bool includeLocalProperties)
        {
            var c = new Object
                    {
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Object clone, bool includeLocalProperties);
    }


    public partial class Operation : EtRestEntityBase 
    {
        public Update update { get; set; }
        
        public Operation Clone(bool includeLocalProperties)
        {
            var c = new Operation
                    {
                        update = update,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Operation clone, bool includeLocalProperties);
    }


    public partial class Organisation : EtRestEntityBase, IHasId 
    {
        public Organisation()
        {
            Components = new List<Picklist>();
            IncidentResolutions = new List<Picklist>();
            IncidentStatuses = new List<Picklist>();
            IncidentTypes = new List<Picklist>();
            Priorities = new List<Picklist>();
            ProjectCategories = new List<ProjectCategory>();
            Projects = new List<Project>();
            RelationshipTypes = new List<RelationshipType>();
            RequirementDifficulties = new List<Picklist>();
            RequirementStatuses = new List<Picklist>();
            RequirementTypes = new List<Picklist>();
            Statuses = new List<Picklist>();
            TestTypes = new List<Picklist>();
            Versions = new List<Picklist>();
        }

        public List<Picklist> Components { get; set; }
        public string Id { get; set; }
        public List<Picklist> IncidentResolutions { get; set; }
        public List<Picklist> IncidentStatuses { get; set; }
        public List<Picklist> IncidentTypes { get; set; }
        public string IndustryType { get; set; }
        public string LongDescription { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public List<Picklist> Priorities { get; set; }
        public List<ProjectCategory> ProjectCategories { get; set; }
        public List<Project> Projects { get; set; }
        public List<RelationshipType> RelationshipTypes { get; set; }
        public List<Picklist> RequirementDifficulties { get; set; }
        public List<Picklist> RequirementStatuses { get; set; }
        public List<Picklist> RequirementTypes { get; set; }
        public string ShortDescription { get; set; }
        public List<Picklist> Statuses { get; set; }
        public List<Picklist> TestTypes { get; set; }
        public List<Picklist> Versions { get; set; }
        
        public Organisation Clone(bool includeLocalProperties)
        {
            var c = new Organisation
                    {
                        Id = Id,
                        IndustryType = IndustryType,
                        LongDescription = LongDescription,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        ShortDescription = ShortDescription,
                        Components = Components.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentResolutions = IncidentResolutions.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentStatuses = IncidentStatuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentTypes = IncidentTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Priorities = Priorities.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ProjectCategories = ProjectCategories.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Projects = Projects.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RelationshipTypes = RelationshipTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementDifficulties = RequirementDifficulties.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementStatuses = RequirementStatuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementTypes = RequirementTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Statuses = Statuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        TestTypes = TestTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Versions = Versions.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Organisation clone, bool includeLocalProperties);
    }


    public partial class Permission : EtRestEntityBase, IHasId 
    {
        public Permission()
        {
            Children = new List<Permission>();
        }

        public List<Permission> Children { get; set; }
        public string Comment { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        
        public Permission Clone(bool includeLocalProperties)
        {
            var c = new Permission
                    {
                        Comment = Comment,
                        Id = Id,
                        Key = Key,
                        Name = Name,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Permission clone, bool includeLocalProperties);
    }


    public partial class PermissionAssignment : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Key { get; set; }
        
        public PermissionAssignment Clone(bool includeLocalProperties)
        {
            var c = new PermissionAssignment
                    {
                        Id = Id,
                        Key = Key,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(PermissionAssignment clone, bool includeLocalProperties);
    }


    public partial class Picklist : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public int SortOrder { get; set; }
        public string Text { get; set; }
        
        public Picklist Clone(bool includeLocalProperties)
        {
            var c = new Picklist
                    {
                        Id = Id,
                        SortOrder = SortOrder,
                        Text = Text,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Picklist clone, bool includeLocalProperties);
    }


    public partial class PicklistCollection : EtRestEntityBase 
    {
        public PicklistCollection()
        {
            Items = new List<Picklist>();
        }

        public List<Picklist> Items { get; set; }
        public string Text { get; set; }
        
        public PicklistCollection Clone(bool includeLocalProperties)
        {
            var c = new PicklistCollection
                    {
                        Text = Text,
                        Items = Items.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(PicklistCollection clone, bool includeLocalProperties);
    }


    public partial class PickListValue : EtRestEntityBase 
    {
        public Add add { get; set; }
        public Remove remove { get; set; }
        public Set set { get; set; }
        
        public PickListValue Clone(bool includeLocalProperties)
        {
            var c = new PickListValue
                    {
                        add = add,
                        remove = remove,
                        set = set,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(PickListValue clone, bool includeLocalProperties);
    }


    public partial class Project : EtRestEntityBase, IHasId 
    {
        public Project()
        {
            Components = new List<Picklist>();
            ExecutionPackages = new List<ExecutionPackage>();
            ExternalSystemLinks = new List<ExternalSystemLink>();
            IncidentResolutions = new List<Picklist>();
            IncidentStatuses = new List<Picklist>();
            IncidentTypes = new List<Picklist>();
            Priorities = new List<Picklist>();
            RequirementDifficulties = new List<Picklist>();
            RequirementPackages = new List<RequirementPackage>();
            RequirementStatuses = new List<Picklist>();
            RequirementTypes = new List<Picklist>();
            ScriptPackages = new List<ScriptPackage>();
            Statuses = new List<Picklist>();
            TestTypes = new List<Picklist>();
            Versions = new List<Picklist>();
        }

        public bool AutoNumberRequirements { get; set; }
        public bool AutoNumberScripts { get; set; }
        public List<Picklist> Components { get; set; }
        public string Description { get; set; }
        public string EstimatedEndDate { get; set; }
        public List<ExecutionPackage> ExecutionPackages { get; set; }
        public List<ExternalSystemLink> ExternalSystemLinks { get; set; }
        public string Id { get; set; }
        public List<Picklist> IncidentResolutions { get; set; }
        public List<Picklist> IncidentStatuses { get; set; }
        public List<Picklist> IncidentTypes { get; set; }
        public bool Independent { get; set; }
        public string ManagerId { get; set; }
        public string ManagerUserName { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public string OrganisationId { get; set; }
        public string OrganisationName { get; set; }
        public List<Picklist> Priorities { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
        public string ProjectCategoryId { get; set; }
        public string ProjectCategoryName { get; set; }
        public List<Picklist> RequirementDifficulties { get; set; }
        public bool RequirementNumberReadOnly { get; set; }
        public List<RequirementPackage> RequirementPackages { get; set; }
        public List<Picklist> RequirementStatuses { get; set; }
        public List<Picklist> RequirementTypes { get; set; }
        public bool ScriptNumberReadOnly { get; set; }
        public List<ScriptPackage> ScriptPackages { get; set; }
        public string Slug { get; set; }
        public string StartDate { get; set; }
        public List<Picklist> Statuses { get; set; }
        public List<Picklist> TestTypes { get; set; }
        public TimeTrackingConfiguration TimeTrackingConfiguration { get; set; }
        public List<Picklist> Versions { get; set; }
        public EntityTypeWidgets Widgets { get; set; }
        
        public Project Clone(bool includeLocalProperties)
        {
            var c = new Project
                    {
                        AutoNumberRequirements = AutoNumberRequirements,
                        AutoNumberScripts = AutoNumberScripts,
                        Description = Description,
                        EstimatedEndDate = EstimatedEndDate,
                        Id = Id,
                        Independent = Independent,
                        ManagerId = ManagerId,
                        ManagerUserName = ManagerUserName,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        OrganisationId = OrganisationId,
                        OrganisationName = OrganisationName,
                        ProjectCategory = ProjectCategory,
                        ProjectCategoryId = ProjectCategoryId,
                        ProjectCategoryName = ProjectCategoryName,
                        RequirementNumberReadOnly = RequirementNumberReadOnly,
                        ScriptNumberReadOnly = ScriptNumberReadOnly,
                        Slug = Slug,
                        StartDate = StartDate,
                        TimeTrackingConfiguration = TimeTrackingConfiguration,
                        Widgets = Widgets,
                        Components = Components.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ExecutionPackages = ExecutionPackages.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ExternalSystemLinks = ExternalSystemLinks.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentResolutions = IncidentResolutions.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentStatuses = IncidentStatuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        IncidentTypes = IncidentTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Priorities = Priorities.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementDifficulties = RequirementDifficulties.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementPackages = RequirementPackages.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementStatuses = RequirementStatuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        RequirementTypes = RequirementTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        ScriptPackages = ScriptPackages.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Statuses = Statuses.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        TestTypes = TestTypes.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Versions = Versions.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Project clone, bool includeLocalProperties);
    }


    public partial class ProjectCategory : EtRestEntityBase, IHasId 
    {
        public ProjectCategory()
        {
            Children = new List<ProjectCategory>();
            Projects = new List<Project>();
        }

        public List<ProjectCategory> Children { get; set; }
        public bool HasChildren { get; set; }
        public bool HasParent { get; set; }
        public bool HasProjects { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public Organisation Organisation { get; set; }
        public string OrganisationId { get; set; }
        public string OrganisationName { get; set; }
        public ProjectCategory Parent { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
        public List<Project> Projects { get; set; }
        
        public ProjectCategory Clone(bool includeLocalProperties)
        {
            var c = new ProjectCategory
                    {
                        HasChildren = HasChildren,
                        HasParent = HasParent,
                        HasProjects = HasProjects,
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        Organisation = Organisation,
                        OrganisationId = OrganisationId,
                        OrganisationName = OrganisationName,
                        Parent = Parent,
                        ParentId = ParentId,
                        ParentName = ParentName,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Projects = Projects.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ProjectCategory clone, bool includeLocalProperties);
    }


    public partial class ProjectTemplate : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        
        public ProjectTemplate Clone(bool includeLocalProperties)
        {
            var c = new ProjectTemplate
                    {
                        Id = Id,
                        Title = Title,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ProjectTemplate clone, bool includeLocalProperties);
    }


    public partial class QueuedMessage : EtRestEntityBase, IHasId 
    {
        public QueuedMessage()
        {
            To = new List<MailAddress>();
        }

        public string Body { get; set; }
        public string EnqueuedAt { get; set; }
        public string Id { get; set; }
        public string Subject { get; set; }
        public List<MailAddress> To { get; set; }
        
        public QueuedMessage Clone(bool includeLocalProperties)
        {
            var c = new QueuedMessage
                    {
                        Body = Body,
                        EnqueuedAt = EnqueuedAt,
                        Id = Id,
                        Subject = Subject,
                        To = To.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(QueuedMessage clone, bool includeLocalProperties);
    }


    public partial class Relationship : EtRestEntityBase 
    {
        public Relationship()
        {
            Children = new List<Relationship>();
        }

        public string AssignedTo { get; set; }
        public bool CanDelete { get; set; }
        public bool CanEdit { get; set; }
        public List<Relationship> Children { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string PackageEntityType { get; set; }
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string PackagePath { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
        public string ParentPath { get; set; }
        public string Priority { get; set; }
        public string Relation { get; set; }
        public string RelationshipDirection { get; set; }
        public string RelationshipId { get; set; }
        public string RelationshipType { get; set; }
        public string RelationshipTypeKey { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        
        public Relationship Clone(bool includeLocalProperties)
        {
            var c = new Relationship
                    {
                        AssignedTo = AssignedTo,
                        CanDelete = CanDelete,
                        CanEdit = CanEdit,
                        EntityId = EntityId,
                        EntityType = EntityType,
                        Name = Name,
                        Number = Number,
                        PackageEntityType = PackageEntityType,
                        PackageId = PackageId,
                        PackageName = PackageName,
                        PackagePath = PackagePath,
                        ParentId = ParentId,
                        ParentName = ParentName,
                        ParentPath = ParentPath,
                        Priority = Priority,
                        Relation = Relation,
                        RelationshipDirection = RelationshipDirection,
                        RelationshipId = RelationshipId,
                        RelationshipType = RelationshipType,
                        RelationshipTypeKey = RelationshipTypeKey,
                        Status = Status,
                        Type = Type,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Relationship clone, bool includeLocalProperties);
    }


    public partial class RelationshipType : EtRestEntityBase 
    {
        public RelationshipType()
        {
            AllowableDirections = new List<INamedEntity>();
        }

        public List<INamedEntity> AllowableDirections { get; set; }
        public bool CanCreateRelationshipsOfThisType { get; set; }
        public bool CanDeleteRelationshipsOfThisType { get; set; }
        public bool CanEditRelationshipsOfThisType { get; set; }
        public string DestinationEntityType { get; set; }
        public string DestinationToSourceLabel { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string OrganisationId { get; set; }
        public string SourceEntityType { get; set; }
        public string SourceToDestinationLabel { get; set; }
        
        public RelationshipType Clone(bool includeLocalProperties)
        {
            var c = new RelationshipType
                    {
                        CanCreateRelationshipsOfThisType = CanCreateRelationshipsOfThisType,
                        CanDeleteRelationshipsOfThisType = CanDeleteRelationshipsOfThisType,
                        CanEditRelationshipsOfThisType = CanEditRelationshipsOfThisType,
                        DestinationEntityType = DestinationEntityType,
                        DestinationToSourceLabel = DestinationToSourceLabel,
                        Key = Key,
                        Name = Name,
                        OrganisationId = OrganisationId,
                        SourceEntityType = SourceEntityType,
                        SourceToDestinationLabel = SourceToDestinationLabel,
                        AllowableDirections = AllowableDirections.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(RelationshipType clone, bool includeLocalProperties);
    }


    public partial class Remove : EtRestEntityBase 
    {
        public string id { get; set; }
        public string ownerId { get; set; }
        
        public Remove Clone(bool includeLocalProperties)
        {
            var c = new Remove
                    {
                        id = id,
                        ownerId = ownerId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Remove clone, bool includeLocalProperties);
    }


    public partial class Requirement : EtRestEntityBase, IHasId 
    {
        public Requirement()
        {
            Attachments = new List<RequirementAttachment>();
            Children = new List<Requirement>();
            Widgets = new List<AbstractWidget>();
        }

        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public List<RequirementAttachment> Attachments { get; set; }
        public string ChangeComment { get; set; }
        public List<Requirement> Children { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string Description { get; set; }
        public Picklist DifficultyLevel { get; set; }
        public string DifficultyLevelId { get; set; }
        public string EstimatedDuration { get; set; }
        public object FieldValues { get; set; }
        public bool HasAttachments { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedById { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public int OrderNumber { get; set; }
        public RequirementPackage Package { get; set; }
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string ParentId { get; set; }
        public string ParentName { get; set; }
        public Picklist Priority { get; set; }
        public string PriorityId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Picklist Status { get; set; }
        public string StatusId { get; set; }
        public Picklist Type { get; set; }
        public string TypeId { get; set; }
        public int VersionNumber { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public Requirement Clone(bool includeLocalProperties)
        {
            var c = new Requirement
                    {
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        ChangeComment = ChangeComment,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        CreatedById = CreatedById,
                        Description = Description,
                        DifficultyLevel = DifficultyLevel,
                        DifficultyLevelId = DifficultyLevelId,
                        EstimatedDuration = EstimatedDuration,
                        FieldValues = FieldValues,
                        HasAttachments = HasAttachments,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedBy = LastUpdatedBy,
                        LastUpdatedById = LastUpdatedById,
                        Name = Name,
                        Number = Number,
                        OrderNumber = OrderNumber,
                        Package = Package,
                        PackageId = PackageId,
                        PackageName = PackageName,
                        ParentId = ParentId,
                        ParentName = ParentName,
                        Priority = Priority,
                        PriorityId = PriorityId,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        Status = Status,
                        StatusId = StatusId,
                        Type = Type,
                        TypeId = TypeId,
                        VersionNumber = VersionNumber,
                        Attachments = Attachments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Requirement clone, bool includeLocalProperties);
    }


    public partial class RequirementAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string RequirementId { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        
        public RequirementAttachment Clone(bool includeLocalProperties)
        {
            var c = new RequirementAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        RequirementId = RequirementId,
                        Size = Size,
                        SourceId = SourceId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(RequirementAttachment clone, bool includeLocalProperties);
    }


    public partial class RequirementPackage : EtRestEntityBase, IHasId 
    {
        public RequirementPackage()
        {
            Children = new List<RequirementPackage>();
            Requirements = new List<Requirement>();
        }

        public List<RequirementPackage> Children { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public RequirementPackage Parent { get; set; }
        public string ParentId { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public List<Requirement> Requirements { get; set; }
        
        public RequirementPackage Clone(bool includeLocalProperties)
        {
            var c = new RequirementPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        Parent = Parent,
                        ParentId = ParentId,
                        Project = Project,
                        ProjectId = ProjectId,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Requirements = Requirements.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(RequirementPackage clone, bool includeLocalProperties);
    }


    public partial class ResourceInfo : EtRestEntityBase 
    {
        public ResourceInfo()
        {
            SupportedHttpMethods = new List<string>();
        }

        public string Description { get; set; }
        public string Help { get; set; }
        public string Href { get; set; }
        public string Rel { get; set; }
        public List<string> SupportedHttpMethods { get; set; }
        public bool SupportsOData { get; set; }
        public bool SupportsTQL { get; set; }
        public string Title { get; set; }
        
        public ResourceInfo Clone(bool includeLocalProperties)
        {
            var c = new ResourceInfo
                    {
                        Description = Description,
                        Help = Help,
                        Href = Href,
                        Rel = Rel,
                        SupportsOData = SupportsOData,
                        SupportsTQL = SupportsTQL,
                        Title = Title,
                        SupportedHttpMethods = SupportedHttpMethods.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ResourceInfo clone, bool includeLocalProperties);
    }


    public partial class Resources : EtRestEntityBase 
    {
        
        public Resources Clone(bool includeLocalProperties)
        {
            var c = new Resources
                    {
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Resources clone, bool includeLocalProperties);
    }


    public partial class ResultNode : EtRestEntityBase, IHasId 
    {
        public ResultNode()
        {
            Children = new List<ResultNode>();
        }

        public List<ResultNode> Children { get; set; }
        public string Description { get; set; }
        public double DurationInSeconds { get; set; }
        public string FinishedAt { get; set; }
        public bool HasAttachments { get; set; }
        public bool HasChildren { get; set; }
        public bool HasIncidents { get; set; }
        public string Id { get; set; }
        public int? Iteration { get; set; }
        public object Metadata { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public object Parameters { get; set; }
        public string StartedAt { get; set; }
        public string Status { get; set; }
        
        public ResultNode Clone(bool includeLocalProperties)
        {
            var c = new ResultNode
                    {
                        Description = Description,
                        DurationInSeconds = DurationInSeconds,
                        FinishedAt = FinishedAt,
                        HasAttachments = HasAttachments,
                        HasChildren = HasChildren,
                        HasIncidents = HasIncidents,
                        Id = Id,
                        Iteration = Iteration,
                        Metadata = Metadata,
                        Name = Name,
                        Notes = Notes,
                        Parameters = Parameters,
                        StartedAt = StartedAt,
                        Status = Status,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ResultNode clone, bool includeLocalProperties);
    }


    public partial class Scope : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
        public Scope Clone(bool includeLocalProperties)
        {
            var c = new Scope
                    {
                        Id = Id,
                        Name = Name,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Scope clone, bool includeLocalProperties);
    }


    public partial class Script : EtRestEntityBase, IHasId 
    {
        public Script()
        {
            Assignments = new List<ScriptAssignment>();
            Attachments = new List<ScriptAttachment>();
            Steps = new List<Step>();
            Widgets = new List<AbstractWidget>();
        }

        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public List<ScriptAssignment> Assignments { get; set; }
        public List<ScriptAttachment> Attachments { get; set; }
        public string ChangeComment { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public string Description { get; set; }
        public string EstimatedDuration { get; set; }
        public object FieldValues { get; set; }
        public bool HasAttachments { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedById { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int? Number { get; set; }
        public string Objective { get; set; }
        public int OrderNumber { get; set; }
        public ScriptPackage Package { get; set; }
        public string PackageId { get; set; }
        public string PackageName { get; set; }
        public string PostCondition { get; set; }
        public string PreCondition { get; set; }
        public Picklist Priority { get; set; }
        public string PriorityId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Picklist Status { get; set; }
        public string StatusId { get; set; }
        public List<Step> Steps { get; set; }
        public Picklist Type { get; set; }
        public string TypeId { get; set; }
        public int VersionNumber { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public Script Clone(bool includeLocalProperties)
        {
            var c = new Script
                    {
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        ChangeComment = ChangeComment,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        CreatedById = CreatedById,
                        Description = Description,
                        EstimatedDuration = EstimatedDuration,
                        FieldValues = FieldValues,
                        HasAttachments = HasAttachments,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedBy = LastUpdatedBy,
                        LastUpdatedById = LastUpdatedById,
                        Name = Name,
                        Notes = Notes,
                        Number = Number,
                        Objective = Objective,
                        OrderNumber = OrderNumber,
                        Package = Package,
                        PackageId = PackageId,
                        PackageName = PackageName,
                        PostCondition = PostCondition,
                        PreCondition = PreCondition,
                        Priority = Priority,
                        PriorityId = PriorityId,
                        ProjectId = ProjectId,
                        ProjectName = ProjectName,
                        Status = Status,
                        StatusId = StatusId,
                        Type = Type,
                        TypeId = TypeId,
                        VersionNumber = VersionNumber,
                        Assignments = Assignments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Attachments = Attachments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Steps = Steps.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Script clone, bool includeLocalProperties);
    }


    public partial class ScriptAssignment : EtRestEntityBase, IHasId 
    {
        public ScriptAssignment()
        {
            Runs = new List<ScriptRun>();
        }

        public string AssignedTo { get; set; }
        public string AssignedToId { get; set; }
        public string Id { get; set; }
        public ScriptRun LastRun { get; set; }
        public string Name { get; set; }
        public ExecutionPackage Package { get; set; }
        public string PackageId { get; set; }
        public List<ScriptRun> Runs { get; set; }
        public Script Script { get; set; }
        public string ScriptId { get; set; }
        public string Status { get; set; }
        
        public ScriptAssignment Clone(bool includeLocalProperties)
        {
            var c = new ScriptAssignment
                    {
                        AssignedTo = AssignedTo,
                        AssignedToId = AssignedToId,
                        Id = Id,
                        LastRun = LastRun,
                        Name = Name,
                        Package = Package,
                        PackageId = PackageId,
                        Script = Script,
                        ScriptId = ScriptId,
                        Status = Status,
                        Runs = Runs.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ScriptAssignment clone, bool includeLocalProperties);
    }


    public partial class ScriptAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ScriptId { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        
        public ScriptAttachment Clone(bool includeLocalProperties)
        {
            var c = new ScriptAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        ScriptId = ScriptId,
                        Size = Size,
                        SourceId = SourceId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ScriptAttachment clone, bool includeLocalProperties);
    }


    public partial class ScriptPackage : EtRestEntityBase, IHasId 
    {
        public ScriptPackage()
        {
            Children = new List<ScriptPackage>();
            Scripts = new List<Script>();
        }

        public List<ScriptPackage> Children { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public ScriptPackage Parent { get; set; }
        public string ParentId { get; set; }
        public Project Project { get; set; }
        public string ProjectId { get; set; }
        public List<Script> Scripts { get; set; }
        
        public ScriptPackage Clone(bool includeLocalProperties)
        {
            var c = new ScriptPackage
                    {
                        Id = Id,
                        Name = Name,
                        OrderNumber = OrderNumber,
                        Parent = Parent,
                        ParentId = ParentId,
                        Project = Project,
                        ProjectId = ProjectId,
                        Children = Children.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Scripts = Scripts.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ScriptPackage clone, bool includeLocalProperties);
    }


    public partial class ScriptRun : EtRestEntityBase, IHasId 
    {
        public ScriptRun()
        {
            StepResults = new List<StepResult>();
            Widgets = new List<AbstractWidget>();
        }

        public string ActualDuration { get; set; }
        public ScriptAssignment Assignment { get; set; }
        public string AssignmentId { get; set; }
        public bool? Completed { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedById { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public string LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedById { get; set; }
        public string RunBy { get; set; }
        public string RunById { get; set; }
        public string ScriptId { get; set; }
        public int ScriptVersion { get; set; }
        public string Status { get; set; }
        public List<StepResult> StepResults { get; set; }
        public List<AbstractWidget> Widgets { get; set; }
        
        public ScriptRun Clone(bool includeLocalProperties)
        {
            var c = new ScriptRun
                    {
                        ActualDuration = ActualDuration,
                        Assignment = Assignment,
                        AssignmentId = AssignmentId,
                        Completed = Completed,
                        CreatedAt = CreatedAt,
                        CreatedBy = CreatedBy,
                        CreatedById = CreatedById,
                        FieldValues = FieldValues,
                        Id = Id,
                        LastUpdatedAt = LastUpdatedAt,
                        LastUpdatedBy = LastUpdatedBy,
                        LastUpdatedById = LastUpdatedById,
                        RunBy = RunBy,
                        RunById = RunById,
                        ScriptId = ScriptId,
                        ScriptVersion = ScriptVersion,
                        Status = Status,
                        StepResults = StepResults.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Widgets = Widgets.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(ScriptRun clone, bool includeLocalProperties);
    }


    public partial class Set : EtRestEntityBase 
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ownerId { get; set; }
        public int sortOrder { get; set; }
        public string text { get; set; }
        public string value { get; set; }
        public string valueType { get; set; }
        
        public Set Clone(bool includeLocalProperties)
        {
            var c = new Set
                    {
                        id = id,
                        name = name,
                        ownerId = ownerId,
                        sortOrder = sortOrder,
                        text = text,
                        value = value,
                        valueType = valueType,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Set clone, bool includeLocalProperties);
    }


    public partial class SetPassword : EtRestEntityBase 
    {
        public string Password { get; set; }
        
        public SetPassword Clone(bool includeLocalProperties)
        {
            var c = new SetPassword
                    {
                        Password = Password,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SetPassword clone, bool includeLocalProperties);
    }


    public partial class Step : EtRestEntityBase 
    {
        public string Data { get; set; }
        public string Description { get; set; }
        public string ExpectedResult { get; set; }
        public string Notes { get; set; }
        public int OrderNumber { get; set; }
        
        public Step Clone(bool includeLocalProperties)
        {
            var c = new Step
                    {
                        Data = Data,
                        Description = Description,
                        ExpectedResult = ExpectedResult,
                        Notes = Notes,
                        OrderNumber = OrderNumber,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Step clone, bool includeLocalProperties);
    }


    public partial class StepResult : EtRestEntityBase, IHasId 
    {
        public StepResult()
        {
            Attachments = new List<StepResultAttachment>();
            Incidents = new List<StepRunResultIncident>();
        }

        public string ActualResult { get; set; }
        public List<StepResultAttachment> Attachments { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public string ExpectedResult { get; set; }
        public bool HasAttachments { get; set; }
        public bool HasIncidents { get; set; }
        public string Id { get; set; }
        public List<StepRunResultIncident> Incidents { get; set; }
        public string Notes { get; set; }
        public string Outcome { get; set; }
        public ScriptRun Run { get; set; }
        public string RunId { get; set; }
        
        public StepResult Clone(bool includeLocalProperties)
        {
            var c = new StepResult
                    {
                        ActualResult = ActualResult,
                        Data = Data,
                        Description = Description,
                        ExpectedResult = ExpectedResult,
                        HasAttachments = HasAttachments,
                        HasIncidents = HasIncidents,
                        Id = Id,
                        Notes = Notes,
                        Outcome = Outcome,
                        Run = Run,
                        RunId = RunId,
                        Attachments = Attachments.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        Incidents = Incidents.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(StepResult clone, bool includeLocalProperties);
    }


    public partial class StepResultAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        public string StepResultId { get; set; }
        
        public StepResultAttachment Clone(bool includeLocalProperties)
        {
            var c = new StepResultAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        Size = Size,
                        SourceId = SourceId,
                        StepResultId = StepResultId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(StepResultAttachment clone, bool includeLocalProperties);
    }


    public partial class StepRunResultIncident : EtRestEntityBase 
    {
        public string IncidentId { get; set; }
        public string StepResultId { get; set; }
        
        public StepRunResultIncident Clone(bool includeLocalProperties)
        {
            var c = new StepRunResultIncident
                    {
                        IncidentId = IncidentId,
                        StepResultId = StepResultId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(StepRunResultIncident clone, bool includeLocalProperties);
    }


    public partial class SwaggerApiResource : EtRestEntityBase 
    {
        public string description { get; set; }
        public string path { get; set; }
        
        public SwaggerApiResource Clone(bool includeLocalProperties)
        {
            var c = new SwaggerApiResource
                    {
                        description = description,
                        path = path,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SwaggerApiResource clone, bool includeLocalProperties);
    }


    public partial class SwaggerResourceListing : EtRestEntityBase 
    {
        public SwaggerResourceListing()
        {
            apis = new List<SwaggerApiResource>();
        }

        public List<SwaggerApiResource> apis { get; set; }
        public string apiVersion { get; set; }
        public string basePath { get; set; }
        public string swaggerVersion { get; set; }
        
        public SwaggerResourceListing Clone(bool includeLocalProperties)
        {
            var c = new SwaggerResourceListing
                    {
                        apiVersion = apiVersion,
                        basePath = basePath,
                        swaggerVersion = swaggerVersion,
                        apis = apis.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SwaggerResourceListing clone, bool includeLocalProperties);
    }


    public partial class SynchronizationScheduleConfiguration : EtRestEntityBase 
    {
        public int? HourOfDay { get; set; }
        public int? MinuteOfDay { get; set; }
        public int? PeriodInMinutes { get; set; }
        public string Type { get; set; }
        
        public SynchronizationScheduleConfiguration Clone(bool includeLocalProperties)
        {
            var c = new SynchronizationScheduleConfiguration
                    {
                        HourOfDay = HourOfDay,
                        MinuteOfDay = MinuteOfDay,
                        PeriodInMinutes = PeriodInMinutes,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SynchronizationScheduleConfiguration clone, bool includeLocalProperties);
    }


    public partial class SynchronizationScheduleInfo : EtRestEntityBase, IHasId 
    {
        public string Condition { get; set; }
        public SynchronizationScheduleConfiguration Configuration { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }
        public bool Enabled { get; set; }
        public string Id { get; set; }
        public bool IsRunning { get; set; }
        public string LastRun { get; set; }
        public string LinkId { get; set; }
        public string NextRun { get; set; }
        public string Scope { get; set; }
        public string StatusMessage { get; set; }
        
        public SynchronizationScheduleInfo Clone(bool includeLocalProperties)
        {
            var c = new SynchronizationScheduleInfo
                    {
                        Condition = Condition,
                        Configuration = Configuration,
                        Description = Description,
                        Direction = Direction,
                        Enabled = Enabled,
                        Id = Id,
                        IsRunning = IsRunning,
                        LastRun = LastRun,
                        LinkId = LinkId,
                        NextRun = NextRun,
                        Scope = Scope,
                        StatusMessage = StatusMessage,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SynchronizationScheduleInfo clone, bool includeLocalProperties);
    }


    public partial class SystemEvent : EtRestEntityBase, IHasId 
    {
        public string DocumentId { get; set; }
        public string EntityId { get; set; }
        public string EntityType { get; set; }
        public string Id { get; set; }
        public string Level { get; set; }
        public string LinkId { get; set; }
        public string Message { get; set; }
        public string OccurredAt { get; set; }
        public string ReferenceId { get; set; }
        public string Source { get; set; }
        public string SystemId { get; set; }
        public string Type { get; set; }
        
        public SystemEvent Clone(bool includeLocalProperties)
        {
            var c = new SystemEvent
                    {
                        DocumentId = DocumentId,
                        EntityId = EntityId,
                        EntityType = EntityType,
                        Id = Id,
                        Level = Level,
                        LinkId = LinkId,
                        Message = Message,
                        OccurredAt = OccurredAt,
                        ReferenceId = ReferenceId,
                        Source = Source,
                        SystemId = SystemId,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SystemEvent clone, bool includeLocalProperties);
    }


    public partial class SystemInfo : EtRestEntityBase 
    {
        public object Modules { get; set; }
        public string PackagePathSeparator { get; set; }
        public string RootUrl { get; set; }
        public string StaticContentRootUrl { get; set; }
        public string TimeZoneId { get; set; }
        public string UtcOffset { get; set; }
        public string Version { get; set; }
        
        public SystemInfo Clone(bool includeLocalProperties)
        {
            var c = new SystemInfo
                    {
                        Modules = Modules,
                        PackagePathSeparator = PackagePathSeparator,
                        RootUrl = RootUrl,
                        StaticContentRootUrl = StaticContentRootUrl,
                        TimeZoneId = TimeZoneId,
                        UtcOffset = UtcOffset,
                        Version = Version,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(SystemInfo clone, bool includeLocalProperties);
    }


    public partial class Table : EtRestEntityBase 
    {
        public Table()
        {
            ColumnNames = new List<string>();
            Rows = new List<object>();
        }

        public List<string> ColumnNames { get; set; }
        public string Name { get; set; }
        public List<object> Rows { get; set; }
        
        public Table Clone(bool includeLocalProperties)
        {
            var c = new Table
                    {
                        Name = Name,
                        ColumnNames = ColumnNames.ToList(),
                        Rows = Rows.ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Table clone, bool includeLocalProperties);
    }


    public partial class TemporaryAttachment : EtRestEntityBase, IHasId 
    {
        public string ContentType { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedById { get; set; }
        public string FileName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string SourceId { get; set; }
        public string TemporaryId { get; set; }
        
        public TemporaryAttachment Clone(bool includeLocalProperties)
        {
            var c = new TemporaryAttachment
                    {
                        ContentType = ContentType,
                        CreatedAt = CreatedAt,
                        CreatedById = CreatedById,
                        FileName = FileName,
                        Id = Id,
                        Name = Name,
                        Size = Size,
                        SourceId = SourceId,
                        TemporaryId = TemporaryId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TemporaryAttachment clone, bool includeLocalProperties);
    }


    public partial class TemporaryAttachmentSets : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        
        public TemporaryAttachmentSets Clone(bool includeLocalProperties)
        {
            var c = new TemporaryAttachmentSets
                    {
                        Id = Id,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TemporaryAttachmentSets clone, bool includeLocalProperties);
    }


    public partial class TicketSearchResult : EtRestEntityBase, IHasId 
    {
        public ExternalSystemLink ExternalSystem { get; set; }
        public string ExternalSystemId { get; set; }
        public string ExternalSystemName { get; set; }
        public string Id { get; set; }
        public string IncidentId { get; set; }
        public string InternalKey { get; set; }
        public string Key { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        
        public TicketSearchResult Clone(bool includeLocalProperties)
        {
            var c = new TicketSearchResult
                    {
                        ExternalSystem = ExternalSystem,
                        ExternalSystemId = ExternalSystemId,
                        ExternalSystemName = ExternalSystemName,
                        Id = Id,
                        IncidentId = IncidentId,
                        InternalKey = InternalKey,
                        Key = Key,
                        Status = Status,
                        Summary = Summary,
                        Type = Type,
                        Url = Url,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TicketSearchResult clone, bool includeLocalProperties);
    }


    public partial class TimeTrackingConfiguration : EtRestEntityBase 
    {
        public int? DaysPerWeek { get; set; }
        public int? HoursPerDay { get; set; }
        
        public TimeTrackingConfiguration Clone(bool includeLocalProperties)
        {
            var c = new TimeTrackingConfiguration
                    {
                        DaysPerWeek = DaysPerWeek,
                        HoursPerDay = HoursPerDay,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TimeTrackingConfiguration clone, bool includeLocalProperties);
    }


    public partial class TimeZoneInfo : EtRestEntityBase 
    {
        public string CurrentTimeInZone { get; set; }
        public bool Resolved { get; set; }
        public string TimeZoneId { get; set; }
        public string UnresolvedTimeZoneId { get; set; }
        public string UtcOffset { get; set; }
        
        public TimeZoneInfo Clone(bool includeLocalProperties)
        {
            var c = new TimeZoneInfo
                    {
                        CurrentTimeInZone = CurrentTimeInZone,
                        Resolved = Resolved,
                        TimeZoneId = TimeZoneId,
                        UnresolvedTimeZoneId = UnresolvedTimeZoneId,
                        UtcOffset = UtcOffset,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TimeZoneInfo clone, bool includeLocalProperties);
    }


    public partial class TypedId : EtRestEntityBase, IHasId 
    {
        public string Id { get; set; }
        public string Type { get; set; }
        
        public TypedId Clone(bool includeLocalProperties)
        {
            var c = new TypedId
                    {
                        Id = Id,
                        Type = Type,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(TypedId clone, bool includeLocalProperties);
    }


    public partial class Update : EtRestEntityBase 
    {
        public Update()
        {
            customFields = new List<CusField>();
            pickListValues = new List<PickListValue>();
        }

        public List<CusField> customFields { get; set; }
        public List<PickListValue> pickListValues { get; set; }
        
        public Update Clone(bool includeLocalProperties)
        {
            var c = new Update
                    {
                        customFields = customFields.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                        pickListValues = pickListValues.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(Update clone, bool includeLocalProperties);
    }


    public partial class UpdateNotification : EtRestEntityBase 
    {
        public bool Viewed { get; set; }
        
        public UpdateNotification Clone(bool includeLocalProperties)
        {
            var c = new UpdateNotification
                    {
                        Viewed = Viewed,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UpdateNotification clone, bool includeLocalProperties);
    }


    public partial class UpdateRelationship : EtRestEntityBase 
    {
        public string RelationshipDirection { get; set; }
        
        public UpdateRelationship Clone(bool includeLocalProperties)
        {
            var c = new UpdateRelationship
                    {
                        RelationshipDirection = RelationshipDirection,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UpdateRelationship clone, bool includeLocalProperties);
    }


    public partial class UpdateScriptRun : EtRestEntityBase, IHasId 
    {
        public UpdateScriptRun()
        {
            StepResults = new List<UpdateStepResult>();
        }

        public string ActualDuration { get; set; }
        public bool? AttemptToComplete { get; set; }
        public object FieldValues { get; set; }
        public string Id { get; set; }
        public List<UpdateStepResult> StepResults { get; set; }
        public object WidgetValues { get; set; }
        
        public UpdateScriptRun Clone(bool includeLocalProperties)
        {
            var c = new UpdateScriptRun
                    {
                        ActualDuration = ActualDuration,
                        AttemptToComplete = AttemptToComplete,
                        FieldValues = FieldValues,
                        Id = Id,
                        WidgetValues = WidgetValues,
                        StepResults = StepResults.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UpdateScriptRun clone, bool includeLocalProperties);
    }


    public partial class UpdateStepResult : EtRestEntityBase, IHasId 
    {
        public string ActualResult { get; set; }
        public string Id { get; set; }
        public string Outcome { get; set; }
        
        public UpdateStepResult Clone(bool includeLocalProperties)
        {
            var c = new UpdateStepResult
                    {
                        ActualResult = ActualResult,
                        Id = Id,
                        Outcome = Outcome,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UpdateStepResult clone, bool includeLocalProperties);
    }


    public partial class User : EtRestEntityBase, IHasId 
    {
        public User()
        {
            Groups = new List<Group>();
        }

        public string DisplayName { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
        public string FirstName { get; set; }
        public List<Group> Groups { get; set; }
        public string Id { get; set; }
        public bool IsExternal { get; set; }
        public string LastLogIn { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        
        public User Clone(bool includeLocalProperties)
        {
            var c = new User
                    {
                        DisplayName = DisplayName,
                        Email = Email,
                        Enabled = Enabled,
                        FirstName = FirstName,
                        Id = Id,
                        IsExternal = IsExternal,
                        LastLogIn = LastLogIn,
                        LastName = LastName,
                        Phone = Phone,
                        UserName = UserName,
                        Groups = Groups.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(User clone, bool includeLocalProperties);
    }


    public partial class UserGroup : EtRestEntityBase, IHasId 
    {
        public string DisplayName { get; set; }
        public string Id { get; set; }
        
        public UserGroup Clone(bool includeLocalProperties)
        {
            var c = new UserGroup
                    {
                        DisplayName = DisplayName,
                        Id = Id,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UserGroup clone, bool includeLocalProperties);
    }


    public partial class UserPermissionProject : EtRestEntityBase 
    {
        public string ProjectId { get; set; }
        
        public UserPermissionProject Clone(bool includeLocalProperties)
        {
            var c = new UserPermissionProject
                    {
                        ProjectId = ProjectId,
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UserPermissionProject clone, bool includeLocalProperties);
    }


    public partial class UserPermissionProjects : EtRestEntityBase 
    {
        public UserPermissionProjects()
        {
            Projects = new List<UserPermissionProject>();
        }

        public List<UserPermissionProject> Projects { get; set; }
        
        public UserPermissionProjects Clone(bool includeLocalProperties)
        {
            var c = new UserPermissionProjects
                    {
                        Projects = Projects.Select(x=>x.Clone(includeLocalProperties)).ToList(),
                    };
            CopyExtraPropertiesToClone(c, includeLocalProperties);
            return c;
        }

        partial void CopyExtraPropertiesToClone(UserPermissionProjects clone, bool includeLocalProperties);
    }


}


