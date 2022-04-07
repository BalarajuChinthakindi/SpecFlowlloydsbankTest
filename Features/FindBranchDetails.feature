Feature: FindBranchDetails
Find the branch details with given location search

    @Chrome
    Scenario: Find the last displayed branch location details with the given location and verify
        Given you are on the personal banking home page
        When you click on branch finder link
        And search with the word 'Halifax'
        Then select the last displayed branch from the results
        And verify below branch details are displayed successfully
          | Location | Street          | City     | Postcode | SaturdayHrs | SundayHrs |
          | Keighley | 54 North Street | Keighley | BD21 3SJ | Closed      | Closed    |