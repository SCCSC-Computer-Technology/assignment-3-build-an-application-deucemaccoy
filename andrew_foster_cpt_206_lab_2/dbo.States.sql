CREATE TABLE [dbo].[States] (
    [state]       INT        NOT NULL,
    [name]        TEXT       NULL,
    [flag]        TEXT       NULL,
    [flower]      TEXT       NULL,
    [bird]        TEXT       NULL,
    [colors]      TEXT       NULL,
    [population]  INT        NULL,
    [first_city]  TEXT       NULL,
    [second_city] TEXT       NULL,
    [third_city]  TEXT       NULL,
    [capitol]     TEXT       NULL,
    [income]      INT        NULL,
    [it_jobs]     FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([state] ASC)
);

