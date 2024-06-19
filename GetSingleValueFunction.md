// Report Design: Advanced Tag Function – Get Single Value
// Format for Get Single Value: @GetSingleValue:Table Name:Column Name:Condition:String Format:Parameter

/* Explanation of Components
@GetSingleValue - This is the function or command to retrieve a single value.
TableName - The name of the table from which the value will be retrieved.
ColumnName - The name of the column from which the value will be retrieved.
Condition - The condition or filter to apply when retrieving the value. This is usually in SQL WHERE clause format.
StringFormat - The format to apply to the returned value (e.g., number of decimal places).
Parameter - The parameter(s) used in the condition, often passed dynamically. */

//To get value of Standard cost for UOM Carton, return value with 2 decimal places.
@GetSingleValue:Itemuom: Cost:Itemcode=? AND UOM IN ('CTN'):n2:ItemCode:UOM
