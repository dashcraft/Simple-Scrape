# Scrape
A simple Screen Scraper for images from a .csv file.

This was created to solve a specific set of issues.

We had a .csv file that was formatted like so...

SKU# | URL_Image_1 | Url_Image_2

There were thousands of these. They always had 2 images and 3 total columns.

This works by parsing the .csv into 3, using the sku as the filenam for the images and then saving them
in the documents\images folder of your computer.

I may add some other tweaks in the future. But for now it serves its purpose.

To open, download the zip file, copy the Vendor_Image_Parser folder into your
Visual Studio's project directory.

From there navigate to the .sln file and open. Requred references are in the library.
