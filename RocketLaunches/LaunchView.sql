CREATE VIEW [dbo].[LaunchView]
	AS SELECT l.Id, l.Mission, l.LaunchdateTime, l.NET, 
	p.Name as LaunchProvider, r.Name as Rocket, s.Pad as Pad, s.Location as Location,
	l.StageRecovery
	FROM [Launch] l, [LaunchProvider] p, [LaunchSite] s, [Rocket] r
	WHERE p.id = l.LaunchProvider
	AND s.Id = l.LaunchSite
	AND r.Id = l.Rocket
