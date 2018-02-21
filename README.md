# Time-Value-Mapper
Visualization tool for Six Sigma projects.

Import data or complete the spreadsheet within the application to track the time spent on the various steps of a process.
Each record can use either a start and end DateTime or simply a duration of time. The program will calculate the difference of time
from a start and end date.

Assign a classification of "VA" (Value Added), "NVA" (No Value Added), or "BNVA" (Business No Value Added) to each step. 
Valuable time is considered to be steps of a process where value for a consumer was added to the product of the process. 
Non-valuable time is time which does not add any value to a product.
Business non-valuable time is time which is valuable to the business in producing the product, but not valuable to the consumer.

Generate a graph to visualize the data and identify steps of a process which are consuming a large portion of time but adding no value.

You can export the graph, its key, and the data summary to a .JPG image file.

Processes which use a large number of steps (>40) or have lengthy descriptions may create issues in the graph's legend.
Text may run off the screen or into another string. 
