import { useState } from "react";

export const useSignLogic = () => {
   const [enterMode, setEnterMode] = useState<"phone" | "code">("phone");

   const handleFinishForm = (values: any) => {
      if (!values.phone) {
         return;
      }

      if (enterMode === "phone") {
         setEnterMode("code");
      }
   };

   const handleEditPhone = () => {
      setEnterMode("phone");
   }

   return { 
      enterModeCode: enterMode === "code",
      enterModePhone: enterMode === "phone",
      handleFinishForm,
      handleEditPhone
   };
}