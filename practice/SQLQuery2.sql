
--Select FirstName, LastName, CustomerId, Country from Customer where not Country = 'USA';
--select * from Customer where Country = 'Brazil'
--select * from Employee where Title ='Sales Support Agent'

--select BillingCountry ,count(InvoiceId)as invoices from Invoice group by(BillingCountry) order by invoices Desc

/*select Top (1) Track.Name,Milliseconds 
from Track join MediaType
on MediaType.MediaTypeId = Track.MediaTypeId
where MediaType.MediaTypeId = 3
Order By Milliseconds DESC
*/

