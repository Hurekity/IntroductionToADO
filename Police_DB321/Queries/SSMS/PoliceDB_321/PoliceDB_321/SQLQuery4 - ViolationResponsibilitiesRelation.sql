USE PoliceDB_321
GO

DROP TABLE ViolationsPesponsibilitiesRelation

CREATE TABLE ViolationsPesponsibilitiesRelation
(
     violation SMALLINT NOT NULL,
	 responsibility SMALLINT NOT NULL,
	 CONSTRAINT PR_VRR PRIMARY KEY (violation, responsibility),
	 CONSTRAINT FK_VRR_Violations FOREIGN KEY (violation) REFERENCES Violations (violation_id),
	 CONSTRAINT FK_VRR_Responsibilities FOREIGN KEY (responsibility) REFERENCES Responsibilities (responsibility_id)
	 )