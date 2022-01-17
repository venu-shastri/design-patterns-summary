#### Case Study :1 

-----

Introducing Mutual Fund Investors Club  (Mutual Fund Investors Club) is a Mutual Fund Purchase  and Advisory agency that was created to change the way people make decisions about  purchasing Mutual fund  and other related services around the world. To do so, they are developing an online service where every detail of a  Mutual Fund purchase  will be assisted by a club of experts specifically selected for each Mutual Fund. 
The concept of this platform is that you user can be both a Purchaser and a Mutual Fund  expert at the same time. The more you participate as an expert in a Mutual Fund  Type , the higher the points you will score. These points can be redeemed to pay SIP.
The customer came with the following requirements for the platform. 

##### Common user view:

- Promotional Mutual Fund  Info on the home page
- Search for Mutual Funds
- Details for Each Mutual Fund
  - Buy a Mutual Fund
  - Buy a Mutual  with a club of experts included:
    - Comment on your experience
    - Ask an expert
    - Evaluate an expert
- Register as a common user
- Mutual Fund expert view:
  - The same view as the common user view
  - Answer the questions asking for  Mutual Fund expertise
- Manage the points you scored answering questions:
  - Exchange points for SIP
- Administrator view:
  - Manage Mutual Funds
  - Manage common users
  - Manage Mutual Fund Experts



#### Case Study : 2

-------------------

The Feature Mesh software system will be a Cloud native feature store . This system will be designed to maximize the Data Scientists productivity by providing a platform to assist in feature engineering where the push and the pull of features from the platform is provided as a service along with other value-added functionality described later in the document. By maximizing the data scientist’s and Data Engineer’s work efficiency and production the system will meet their needs while remaining easy to understand and use.

##### UseCases

- The Data Scientist accesses the platform and publishes the built feature on the platform

  - The user specifies metadata for the features that would be used while searching.
  - The user leverages the GUI or the library to push the developed feature onto the platform.
  - The system displays the status message of the push operation to the user.

- The Data Scientist accesses the platform and searches for the intended feature from the platform.

  - The user chooses to search by feature name, keyword, timestamp etc.
  - The system displays the choices to the user.
  - The user selects the desired feature from the search results.
  - The system presents the abstract of the feature to the user.
  - The user chooses to re-use the feature.
  - The system provides the requested feature.

   

-  The Data Scientist accesses the platform and uses the published feature for model training using the offline store within the platform. 

  - The user leverages the built library from featuremesh to get the values of a feature for training the analytical model in his environment (i.e: Jupyter-Notebook etc)
  -    The query parameters for the library call would include the feature Name and any other associated meta-data of the feature.
  -  The system responds back with either a success status with associated feature value or an Error
  -  The user has to program to catch any exceptions/errors thrown by the platform.
  -  The workload for Offline store typically would involve Batch processing.

   

-  Platform that facilitates real time feature consumption for inferencing done by the analytical model deployed in production.

- Develop a Library and/or use GUI is built in to the platform for Data Scientists to use.

 ·   

#### Case Study : 3

----

A global investment bank based in India, New York and Singapore trades (buys and sells) financial products with other banks (“*counterparties*"). When share prices on the stock markets move up or down, the bank either makes money or loses it. At the end of the working day, the bank needs to gain a view of how much risk of losing money they are exposed to, by running some calculations on the data held about their trades. The bank has an existing Trade Data System (TDS) and Reference Data System (RDS) but needs a new Risk System.

 

**Trade Data System (TDS)**

The Trade Data System maintains a store of all trades made by the bank. It is already configured to generate a file-based XML export on a network share of trade data at the close of business (5pm) in NewYork. The export includes the following information for every trade made by the bank: 

• Trade ID, Date, Current trade value in US dollars, Counterparty ID

**Reference Data System (RDS)**

The Reference Data System maintains all of the reference data needed by the bank. This includes

Information about counterparties; each of which represents an individual, a bank, etc. A file-based XML

Export is also available on a network share and includes basic information about each counterparty. A new organization-wide reference data system is due for completion in the next 3 months, with the current system eventually being decommissioned

 

The high-level requirements for the new Risk System are as follows.

 Import trade data from the Trade Data System and Import counterparty data from the Reference Data System. Join the two sets of data together, enriching the trade data with information about the Counterparty, for each counterparty, calculate the risk that the bank is exposed to. Generate a report that can be imported into Microsoft Excel containing the risk figures for all counterparties known by the bank.

 Distribute the report to the business users before the start of the next trading day (9am) in

Singapore. Provide a way for a subset of the business users to configure and maintain the external parameters used by the risk calculations.