השרת הוא שרת בסיסי מאוד הכולל שני נתיבים, ללא עבודה א-סינכרונית וללא אותנטיקציה, ניהול token וכד'.

endpoint: https://localhost:7150

--------------------------------------
routes:
GET /Tickets/list
פרמטרים: ללא
ערך מוחזר: מערך של TimesListDTO הכולל את רשימת זמני הכניסה.

Post /Tickets
פרמטרים : OrderTicketsDTO
ערך מוחזר: OrderTicketsDTO.
אם ההזמנה הצליחה - אותו dto שנשלח.
אם נכשלה - מספר הכרטיסים הוא 0.
שיפור אפשרי: מספר כרטיסים שלילי, כאשר כל מספר הוא קוד שגיאה מותאם.


------------------------------------------
DTOs:

TimesListDTO 
מייצג זמני כניסה אפשריים, כפי שהוגדרו ע"י יד ושם
השדות:
startTime (string)
availablePlaces (int)
isClosed (boolean)


OrderTicketsDTO
מייצג בקשת הזמנה לשעה מסויימת
השדות:
startTime (string) - שעת הכניסה המבוקשת
amout (int) - כמות הכרטיסים המבוקשת
