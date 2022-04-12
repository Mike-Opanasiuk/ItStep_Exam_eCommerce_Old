import { FC } from "react";

export const SortSection: FC = () => {

   const handleSelect = (event: React.ChangeEvent<HTMLSelectElement>) => {
      
   }

   return (
      <div className="flex items-center">
         <span className="text-sm">сортувати за:</span>
         <div className="border rounded px-1 ml-2">
            <select onChange={handleSelect} className="outline-none h-8 border-none app bg-transparent">
               <option>Популярністю</option>
               <option>Відгуками</option>
               <option>Спочатку дорогі</option>
               <option>Спочатку дешеві</option>
            </select>
         </div>
      </div>
   );
};