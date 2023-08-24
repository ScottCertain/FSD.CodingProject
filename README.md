# FSD.CodingProject
ABP.IO Multi-layer + Angular + EF Core + SQL Server

# Class Checklist
## FSD.CodingProject.Application (Project)
* CalculationInputs (Directory)
* [X] CalculationInputAppService (Class)
* Calculations (Directory)
* [ ] CalculationsAppService (Class)
	* [ ] CalculateCurrent(CalculationInputDto input): CalculationResultDto
	* [ ] CalculateHourlyOrAllowedHour(CalculationInputDto input): CalculationResultDto
	* [ ] CalculateFeeSplit(CalculationInputDto input): CalculationResultDto

## FSD.CodingProject.Application.Contracts (Project)
* CalculationInputs (Directory)
	* [X] 	CalculationInputDto (Class)
	* [X] 	ICalculationInputAppService (Class)
	* [X] 	UpdateCalculationInputDto (Class)
* Calculations (Directory)
	* [ ] 	CalculationResultDto (Class)
	* [X] 	ICalculationAppService (Interface)	

## FSD.CodingProject.Domain (Project)
* CalculationInputs (Directory)
	* [X] 	CalculationInputAppService (Class)
* Calculations (Directory)
	* [X] 	CurrentCalculations (Class) implementing the relevant interfaces.
	* [X] 	HourlyOrAllowedHourCalculations (Class) implementing the relevant interfaces.
	* [X] 	FeeSplitCalculations (Class) implementing the relevant interfaces.

## FSD.CodingProject.Domain.Shared (Project)
* CalculationTypes (Directory)
	* [X] 	CalculationType (Class/Enum)	
* Calculations (Directory)
	* [X] 	IRateIncreaseCalculations (Interface)
	* [X] 	ILowerPayrollRevenueCalculations (Interface)
	* [X]	ILowerCustomerTurnoverCalculations (Interface)
	* [X]	ITotalCalculations (Interface)


# NOTES
### CRUD
* CRUD functions are implemented in the CalculationInputs object. I created one row in the database and made it Updatable so that the inputs could changed in order for the calculations to vary.
### Calculations
* I think I got all of the calculations formatted correctly. There might be some percentages to calculate in order for them to show in the client.
### Angular
* The CalculationInput object displays in the client and the EDIT button is functional.
* I have not yet tried to implement the display of the calculations in the client.
### Feedback
* This is a huge projet for me. Here are the parts: learn ABP, learn Angular in the context of ABP, learn Entity Framework more in-depth than I have before, Understand around 50 variations of the calculations and implement them in code.
* Learning ABP was a challenge as I've never worked with anything architected like this before.
* Relearning Angular was a challenge as well. The proxy components made things feel more connected to the backend and somehow more organized.
* Entity Framework hides a lot of the database stuff that I would normally work with, which made it a little unintuitive to work with. All in all I'm sold on it as a great tool.
* Displaying the calculations in the client as a recreation of the spreadsheet might be challenging. CSS and layout for that will be interesting.
* The nature of the calculations is pretty complex to recreate in code. I'm not sure my approach is the best, but I tried to take a brute force approach to try to get something working. In the end, I ran out of time to get the calculations working and tested.
* All in all, I learned a ton in this little crash course. I appreciate the opportunity to try out for your team.