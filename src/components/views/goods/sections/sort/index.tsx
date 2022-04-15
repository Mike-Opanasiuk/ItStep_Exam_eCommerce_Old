import { FC } from "react";
import { Select } from "@base/select";

const sortOptions = [
   { name: "Популярністю", value: "by_popularity" },
   { name: "Відгуками", value: "by_reviews" },
   { name: "Спочатку дорогі", value: "expensive_at_first" },
   { name: "Спочатку дешеві", value: "cheap_at_first" },
]

export const SortSection: FC = () => {

   const handleSelect = (value: string) => {

   }

   return (
      <div className="flex items-center">
         <span className="text-sm">сортувати за:</span>
         <div className="border rounded px-1 ml-2">
            <Select onSelect={handleSelect} options={sortOptions} />
         </div>
      </div>
   );
};