ALTER TABLE Invoice ADD FOREIGN KEY (Customer) REFERENCES customer(Customer_id)
ALTER TABLE payments ADD FOREIGN KEY (Customer) REFERENCES customer(Customer_id)
ALTER TABLE payments ADD FOREIGN KEY (Invoice_ref) REFERENCES Invoice(InvoiceNo)
;