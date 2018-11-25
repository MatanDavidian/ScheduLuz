CREATE TABLE [dbo].[EVENT] (
	[Event_id]            INT         NOT NULL,
    [Event_name]          NCHAR (50)  NOT NULL,
    [Event_details]       NCHAR (250) NULL,
    [event_kind]          NCHAR (10)  NULL,
    [event_place]         NCHAR (10)  NULL,
    [event_privacy]       NCHAR (10)  NULL,
    [up_for_cancellation] NCHAR (10)  NULL,
    [date]                NCHAR (10)  NULL,
    [hours_start]         NCHAR (10)  NULL,
    [minutes_start]       NCHAR (10)  NULL,
    [hours_end]           NCHAR (10)  NULL,
    [minutes_end]         NCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

