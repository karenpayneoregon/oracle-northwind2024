DROP SEQUENCE NORTHWIND.SEQ_NW_EMPLOYEES;

CREATE SEQUENCE NORTHWIND.SEQ_NW_EMPLOYEES
  START WITH 10
  MAXVALUE 999999999999999999999999999
  MINVALUE 1
  NOCYCLE
  NOCACHE
  NOORDER
  NOKEEP
  NOSCALE
  GLOBAL;