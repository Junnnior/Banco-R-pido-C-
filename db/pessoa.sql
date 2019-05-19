CREATE TABLE pessoa
(
  id SERIAL PRIMARY KEY,
  nome character varying(50) NOT NULL,
  senha character varying(50) NOT NULL,
  conta character varying(100) NOT NULL
)