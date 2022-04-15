import { FC, useState } from "react";

const MAX_QUANTITY = 999;

export const Quantity: FC = () => {

   const [value, setValue] = useState(1);

   const increase = () => {
      setValue((prev) => {
         if (prev + 1 <= MAX_QUANTITY) {
            return prev + 1;
         }
         return prev;
      });
   };

   const decrease = () => {
      setValue((prev) => {
         if (prev - 1 > 0) {
            return prev - 1;
         }
         return prev;
      });
   };

   const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
      const value = event.currentTarget.value;
      const num = parseInt(value);
      if (num > 0 && num <= MAX_QUANTITY) {
         setValue(num);
      }
   }

   return (
      <div className="flex">
         <div onClick={decrease} className="rounded-l leading-8 px-3 border border-r-0 hover:bg-gray-50 cursor-pointer">
            -
         </div>
         <input
            name="quantity"
            className="text-center rounedd outline-none border w-12 leading-8 px-2"
            value={value}
            onChange={handleChange}
            max={MAX_QUANTITY}
            datatype="number"
         />
         <div onClick={increase} className="rounded-r leading-8 px-3 border border-l-0 hover:bg-gray-50 cursor-pointer">
            +
         </div>
      </div>
   );
};