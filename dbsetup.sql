-- CREATE TABLE IF NOT EXISTS lifts (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(20) NOT NULL,
--     PRIMARY KEY (id)
-- )

-- CREATE TABLE IF NOT EXISTS liftweights (
--     id int NOT NULL AUTO_INCREMENT,
--     weight int NOT NULL,
--     liftId int NOT NULL,
--     FOREIGN KEY (liftId)
--         REFERENCES lifts(id)
--         ON DELETE CASCADE,
--     PRIMARY KEY (id)
-- )

-- liftweights = liftid(foreign key), weight amount (lbs), date