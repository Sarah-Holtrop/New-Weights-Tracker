-- CREATE TABLE IF NOT EXISTS lifts (
--     id int NOT NULL AUTO_INCREMENT,
--     name VARCHAR(20) NOT NULL,
--     PRIMARY KEY (id)
-- )

-- CREATE TABLE IF NOT EXISTS weights (
--   id int NOT NULL AUTO_INCREMENT,
--   amount int NOT NULL,
--   PRIMARY KEY (id)
-- )

-- CREATE TABLE IF NOT EXISTS liftweights (
--     id int NOT NULL AUTO_INCREMENT,
--     liftId int NOT NULL,
--     weightId int NOT NULL,
--     PRIMARY KEY (id),
--     INDEX(liftId, weightId),
--     FOREIGN KEY (liftId)
--         REFERENCES lifts(id)
--         ON DELETE CASCADE,
--     FOREIGN KEY (weightId)
--         REFERENCES weights(id)
--         ON DELETE CASCADE
-- )

-- liftweights = liftid(foreign key), weight amount (lbs), date

-- DROP TABLE IF EXISTS weights;