Relationship Creator
====================

When converting data from third party systems such as Zephyr or HP Quality Center, it's possible that depending on the process used e.g. CSV files, you may not preserve all the relationship information.

This example demonstrates creating a set of missing relationships via the API, based on a custom field in requirements storing the Zephyr Requirement ID, and a custom filed in test scripts, storing the Zephyr Test Case ID.

The example uses a set of in-memory relationships, though this example would be trivial to modify so that the data was read from a CSV file or Excel spreadsheet instead.