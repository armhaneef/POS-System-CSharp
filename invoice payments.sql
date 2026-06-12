ALTER TABLE Payments
ADD CONSTRAINT FK_Payments_Invoice
FOREIGN KEY (Invoice_ref)
REFERENCES Invoice(InvoiceNo);
